using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto_MVC.Models;
using PrimeiroProjeto_MVC.ViewModels;

namespace PrimeiroProjeto_MVC.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            //var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            var itens = new List<CarrinhoCompraItem>()
            {
                new CarrinhoCompraItem(),
                new CarrinhoCompraItem(),
                new CarrinhoCompraItem()
            };

            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVm = new CarrinhoCompraViewlModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVm);
        }
    }
}
