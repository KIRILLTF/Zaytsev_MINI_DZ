namespace Zaytsev_MINI_DZ
{
    // Интерфейс зоопарка, управляющего животными и инвентаризационными вещами.
    public interface IZoo
    {
        void AddAnimal(Animal animal);
        int GetTotalFoodConsumption();
        IEnumerable<Animal> GetInteractiveAnimals();
        IEnumerable<Animal> GetAllAnimals();
        IEnumerable<IInventory> GetInventoryItems();
        void AddInventoryItem(IInventory item);
    }

    // Класс зоопарка – управляет списками животных и инвентаризационными вещами.
    public class Zoo : IZoo
    {
        private readonly List<Animal> _animals = new List<Animal>();
        private readonly List<IInventory> _inventoryItems = new List<IInventory>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        // Подсчет общего количества потребляемой еды всеми животными.
        public int GetTotalFoodConsumption() => _animals.Sum(a => a.Food);

        // Выборка животных, подходящих для контактного зоопарка (только травоядные с добротой > 5).
        public IEnumerable<Animal> GetInteractiveAnimals()
        {
            return _animals.Where(a => a is Herbo herbo && herbo.CanInteract());
        }

        public IEnumerable<Animal> GetAllAnimals() => _animals;

        public IEnumerable<IInventory> GetInventoryItems() => _inventoryItems;

        public void AddInventoryItem(IInventory item)
        {
            _inventoryItems.Add(item);
        }
    }
}
