using Application.Model;

namespace Application.Service
{
    public class EntityService:IEntityService
    {
        public List<Entity> entityList = new List<Entity>() {
            new Entity()  { Id = 1,Name="Entity1"},
            new Entity()  { Id = 2,Name="Entity2"},
        };
        public EntityService() { }

        public List<Entity> GetEntityService()
        {
            return entityList;
        }


    }
}
