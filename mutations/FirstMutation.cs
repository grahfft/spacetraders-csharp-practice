[ExtendObjectType("Mutation")]
public class FirstMutation 
{
    public async Task<AuthorPayload> AddAuthor(AuthorInput input, [Service] Repository repository)
    {
        var author = new Author(Guid.NewGuid(), input.name);
        await repository.AddAuthor(author);
        return new AuthorPayload(author);
    } 
}