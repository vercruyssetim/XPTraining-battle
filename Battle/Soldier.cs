using System;

namespace Battle
{
    public class Soldier
    {

        public Soldier(string name)
        {
            ValidateNameisNotBlank(name);
            Name = name;
        }

        private void ValidateNameisNotBlank(string name)
        {
            if (string.IsNullOrEmpty(name?.Trim()))
            {
                throw new ArgumentException("name can not be blank");
            }
        }
        public string Name { get; }
    }
}