using System;
using System.Threading.Tasks;
using FoodCore.Contracts;
using FoodCore.Messages;

namespace FoodCore.Business.Steps
{
    public interface IOrderStep
    {
        Task Create(OrderRequest order);
    }
}
