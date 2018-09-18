namespace OOP_RPG
{
    public class Potion : Item
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }

        public Potion(string name, int hp, int originalvalue, int resellvalue)
        {
            this.Name = name;
            this.HP = hp;
            this.OriginalValue = originalvalue;
            ResellValue = resellvalue;
        }
    }
}