using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace ApiEmpresa.Models;
public class Clientes{
    [Key]
    public Int32 id_cliente{get; set;}

    public string? nombres{get; set;}
    public string? apellidos{get; set;}
    public string? direccion{get; set;}
    public string? telefono{get; set;}
    public DateTime? fecha_nacimiento{get; set;}







}