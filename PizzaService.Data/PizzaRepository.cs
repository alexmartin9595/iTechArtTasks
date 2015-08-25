﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaService.Entities;

namespace PizzaService.Data
{
    public class PizzaRepository
    {
        private PizzaSericeContext context;
        private static PizzaRepository instance;

        private PizzaRepository()
        {
            context = new PizzaSericeContext();
        }

        public static PizzaRepository Instance 
        {
            get
            {
                if (instance == null)
                    instance = new PizzaRepository();
                return instance;
            }
        }

        public IEnumerable<Pizza> GetAllPizza()
        {
            return context.Pizzas.Include("PizzaIngredients").ToList();
        }

        public Pizza GetPizzaById(int id)
        {
            return context.Pizzas.FirstOrDefault(x => x.Id == id);
        }

        public void AddPizza(Pizza pizza)
        {
           context.Pizzas.Add(pizza);
           context.SaveChanges();
        }

        public void DeletePizza(Pizza pizza)
        {
            context.Pizzas.Remove(pizza);
            context.SaveChanges();
        }
    }
}
