using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPET.Models;
using LHpet.Model;

namespace LHPET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private object listaClientes;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "william", "000.111.222-33", "william@gmail.com", "gato");
        Cliente cliente2 = new Cliente(02, "William HenryGates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace","800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "LinusTorvalds", "933.622.400-03", "torvalds@osdl.org",  "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper","911.702.988-00", "grace.hopper@cobol.com", "Loboc");
        
        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);

        ViewBag.listaCliente = listaCliente;
        
        Fornecedor fornecedor1 = new Fornecedor(01, "C#PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "CtrlAlt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "TikTok Dogs", "87.945.350/0001-09","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05,"Bifinho Forever", "18.760.614/0001-37","contato@bff.us");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC", "40.810.224/0001-83","boots.pet@gatomania.us");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        
        ViewBag.listaFornecedores = listaFornecedores;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
