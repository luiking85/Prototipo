﻿using System;


public abstract class Vehiculo
{


    public Vehiculo(caracteristicasGenerales _caracteristicasGenerales, caracteristicasEspecificas _caracteristicasEspecificas)
	{
        List<_caracteristicasGenerales> list = new List<caracteristicasGenerales> { new llantas = 2, puertas=4 };
	}


}

public class caracteristicasGenerales
{
    public int llantas { get; set; }
    public int puertas { get; set; }
    public string placa { get; set; }
    public int idchasis { get; set; }
    public string color { get; set; }
    public float peso { get; set; }
}

public class caracteristicasEspecificas
{
    public float cilindraje { get; set; }
    public int valvulas { get; set; }
    public float relacioncompresion { get; set; }

    public tipocombustible combustible { get; set; }
}

public enum tipocombustible
{ 
    "Gas",
    "Diesel",
    "Gasolina",
    "Eletrica"
}

public enum colores
{ 
    "rojo",
    "azul",
    "magenta"
}