namespace Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            int indexOfHeroToRemove = this.data.FindIndex(h => h.Name == name);

            if (indexOfHeroToRemove >= 0 && indexOfHeroToRemove < this.Count)
            {
                this.data.RemoveAt(indexOfHeroToRemove);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            var orderedHeroes = this.data.OrderByDescending(h => h.Item.Strength).ToList();

            var heroToReturn = orderedHeroes[0];
            return heroToReturn;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var orderedHeroes = this.data.OrderByDescending(h => h.Item.Ability).ToList();

            var heroToReturn = orderedHeroes[0];
            return heroToReturn;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var orderedHeroes = this.data.OrderByDescending(h => h.Item.Intelligence).ToList();

            var heroToReturn = orderedHeroes[0];
            return heroToReturn;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in this.data)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
