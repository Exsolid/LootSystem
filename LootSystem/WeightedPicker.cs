using System;
using System.Collections.Generic;
using System.Linq;

namespace LootSystem
{
    public class WeightedPicker<T>
    {
        private readonly Dictionary<T, float> _dictionary = new Dictionary<T, float>();
        private float _sumValues;

        readonly Random _random = new Random();

        public T PickRandom()
        {
            _sumValues = _dictionary.Values.Sum();
            float randomPercentage = _random.Next((int)(_sumValues * 100)) / 100f;

            return PickRandom(randomPercentage);
        }

        public T PickRandom(float percentage)
        {
            KeyValuePair<T, float>? lastPair = null;

            percentage = Math.Min(_sumValues, Math.Max(0, percentage));

            float accumulate = 0;

            foreach (KeyValuePair<T, float> pair in _dictionary)
            {
                if (accumulate > percentage)
                {
                    break;
                }
                lastPair = pair;
                accumulate += pair.Value;

            }

            if (!lastPair.HasValue)
            {
                throw new Exception();
            }

            return lastPair.Value.Key;
        }
        public void Add(T key, float value)
        {
            _dictionary.Add(key, value);
        }

        public void Remove(T key)
        {
            _dictionary.Remove(key);
        }

        public void Clear()
        {
            _dictionary.Clear();
        }

        public bool isEmpty()
        {
            return _dictionary.Count == 0;
        }
    }
}
