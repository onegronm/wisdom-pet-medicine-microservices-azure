## DDD
- Talks about problems as domains, describing independent problem areas as Bounded Contexts. It emphasizes a common languague to talk about these problems and organizes the code so it's aligned to the business problems.
- Complex microservices with ever-changing business logic with a high degree of domain complexity should not be implemented as CRUD components, or you can end up with low-quality code.
- Do not use CQRS and DDD patterns everywhere. Many subsystems, BCs, or microservices are simpler and can be implemented more easily using simple CRUD services or using another approach.
If you have a complex microservice that has logic implemented in the service classes instead of in the domain entities, you could be falling into the anemic domain model
- By putting all the behavior out into service objects (the business layer), you essentially end up with spaghetti code or transaction scripts, and therefore you lose the advantages that a domain model provides.
- If the microservice you are creating is simple enough (for example, a CRUD service), following the anemic domain model it is not an anti-pattern. However, if you need to tackle the complexity of a microservice's domain that has a lot of ever-changing business rules, the anemic domain model might be an anti-pattern for that microservice or Bounded Context. In that case, designing it as a rich model with entities containing data plus behavior as well as implementing additional DDD patterns (aggregates, value objects, etc.) might have huge benefits for the long-term success of such a microservice.


## Integration Event
- A microservice publishes an integration event when something happens within its domain and another microservice needs to be aware of it.

## Domain or Application Core Layer
- The domain model for a microservice or bounded context, reflects understanding of the business domain.
- Holds the business model, which includes entities, services, and interfaces.
- Responsible for representing concepts of the business and business rules.
- Use and control state that reflects the business situation. It must capture the rules, behavior, business language, and constraints of the single Bounded Context.
- Class library with domain entities. Ideally, it must not take dependency on any other layer.
- Include abstractions for operations that will be performed using Infrastructure, such as data access, file system access, network calls, etc.
- **Entities**
- **Aggregates (groups of entities)**
- **Interfaces**
- **Domain Services**
- **Specifications**
- **Custom Exceptions and Guard Clauses**
- **Domain Events and Handlers**

## Entities
- Domain entities with data + behavior.
- Domain entity models are business model classes that are persisted.

### Value objects
- Do not require identity and identity tracking.
- They are immutable. You must provide the required values when the object is constructed and not allow them to change during the object's lifetime.
- Address, for example, is simply a complex value composed of country/region, street, city, etc., and has no identity in the domain.

## Infrastructure
- Data access implementations, most commonly abstracted through the use of the Repository design pattern.
- Repositories, DbContext, Migrations.
- Data access implementation types (Repositories).
- Infrastructure-specific services (for example, FileLogger or SmtpNotifier).

## UI
- No direct instantiation or static calls to infrastructure layer types.

