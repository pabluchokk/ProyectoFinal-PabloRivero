﻿using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionData;
using SistemaGestionEntities;

[ApiController]
[Route("api/[controller]")]
public class ProductoVendidoController : ControllerBase
{
    [HttpPost("CrearProductoVendido")]
    public IActionResult CrearProductoVendido([FromBody] ProductoVendido productoVendido)
    {
        ProductoVendidoData.CrearProductoVendido(productoVendido);
        return Ok("Producto vendido registrado correctamente.");
    }

    [HttpPut("ModificarProductoVendido/{id}")]
    public IActionResult ModificarProductoVendido(int id, [FromBody] ProductoVendido productoVendido)
    {
        productoVendido.Id = id;
        ProductoVendidoData.ModificarProductoVendido(productoVendido);
        return Ok("Producto vendido modificado correctamente.");
    }

    [HttpDelete("EliminarProductoVendido/{id}")]
    public IActionResult EliminarProductoVendido(int id)
    {
        ProductoVendidoData.EliminarProductoVendido(id);
        return Ok("Producto vendido eliminado correctamente.");
    }

    [HttpGet("ListarProductosVendidos")]
    public IActionResult ListarProductosVendidos()
    {
        var productosVendidos = ProductoVendidoData.ListarProductosVendidos();
        return Ok(productosVendidos);
    }

    [HttpGet("ObtenerProductosVendidos")]
    public IActionResult ObtenerProductosVendidos()
    {
        var productosVendidos = ProductoVendidoBusiness.ListarProductosVendidos();
        return Ok(productosVendidos);
    }
}
