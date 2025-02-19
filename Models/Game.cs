namespace BlazorServerSyncfusion.Models
{
    public class Game
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return$"ID: {ID}, Name: {Name}";
        }
    }
}
