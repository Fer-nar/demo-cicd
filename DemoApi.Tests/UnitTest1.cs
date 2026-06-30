using Xunit;

namespace DemoApi.Tests;

public class WeatherTests
{
    [Fact]
    public void Temperatura_debe_estar_en_rango_valido()
    {
        // Arrange
        int temperatura = 25;

        // Act
        bool esValida = temperatura >= -50 && temperatura <= 60;

        // Assert
        Assert.True(esValida);
    }

    [Fact]
    public void Resumen_no_debe_estar_vacio()
    {
        // Arrange
        string resumen = "Caluroso";

        // Assert
        Assert.NotEmpty(resumen);
    }

    [Fact]
    public void Suma_de_temperaturas_es_correcta()
    {
        // Arrange
        int temp1 = 20;
        int temp2 = 30;

        // Act
        int resultado = temp1 + temp2;

        // Assert
        Assert.Equal(50, resultado);
    }
}