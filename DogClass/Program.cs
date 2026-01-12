using System;

namespace Coding.Exercise
{
    public class Dog
    {
        // TODO
        string _name, _breed;
        int _weight;

        public Dog(string name, string breed, int weight)
        {
            this._name = name;
            this._breed = breed;
            this._weight = weight;
        }

        public Dog(string name, int weight) : this(name, "mixed-breed", weight)
        {
        }

        public string Describe()
        {
            string _looks = (_weight < 5) ? "tiny" : (_weight < 30) ? "medium" : "large";
            return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {_looks} dog.";

        }
    }
}
