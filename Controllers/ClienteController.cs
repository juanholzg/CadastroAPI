using CadastroAPI.Context;
using CadastroAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAPI.Controllers;
// Define a rota da controller
// [controller] informa que o nome da rota será o mesmo da controller 
[Route("[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly CadastroApiDbContext _context;

    public ClienteController(CadastroApiDbContext context)
    {
        _context = context;
    }
    [HttpGet("Get")] // Cliente/Get
    public ActionResult<Cliente> Get()
    {
        var clientes = _context.Clientes.ToList();
        return Ok(clientes);
    }

    [HttpGet("GetById/{id}")] // Cliente/GetById
    public ActionResult<Cliente> GetById(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

        if(cliente == null)
        {
            return NotFound("Id não encontrado");
        }

        return Ok(cliente);
    }

    [HttpGet("GetByNome/{nome}")] // Cliente/GetByNome
    public ActionResult<Cliente> GetByNome(string nome)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Nome == nome);

        if (cliente == null)
        {
            return NotFound("Nome não encontrado");
        }

        return Ok(cliente);

    }

    [HttpPost("Post")]
    public ActionResult<Cliente> Post(Cliente cliente)
    {
        if (cliente == null)
        {
            return NotFound();
        }

        _context.Clientes.Add(cliente);
        _context.SaveChanges();

        return Ok();
    }

   

}