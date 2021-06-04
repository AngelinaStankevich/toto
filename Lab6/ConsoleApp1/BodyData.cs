﻿using System;

namespace ConsoleApp1
{
    class BodyData:IComparable<BodyData>
    {
        public string Name { get; }
        public float Weight { get; }
        public float Height { get; }
        public int NormalAmountOfFood { get; }
        BodyData() { }
        public BodyData(string name, float weight, float height, int normalAmountOfFood) 
        {
            Name = name;
            Weight = weight;
            Height = height;
            NormalAmountOfFood = normalAmountOfFood;
        }
        public int CompareTo(BodyData obj) 
        {
            if (Weight > obj.Weight) return 1;
            if (Weight < obj.Weight) return -1;
            else return 0;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}\tWeight: {1}\t Height: {2}\t Food allowance: {3}\t", Name, Weight, Height, NormalAmountOfFood);
        }
    }
}
