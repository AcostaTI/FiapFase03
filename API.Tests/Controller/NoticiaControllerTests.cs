using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net;
using TechchallengeNoticias.Services;
using Webapiaspnet.Controllers;
using Webapiaspnet.Models;

namespace API.Tests.Controller
{
    public class NoticiaControllerTests
    {
        private NoticiaController _noticiaController;
        private Mock<INoticiaService> _noticiaServiceMock;

        public NoticiaControllerTests()
        {
            _noticiaServiceMock = new Mock<INoticiaService>();
            _noticiaController = new NoticiaController(_noticiaServiceMock.Object);   
        }

        [Fact]
        public async Task GetNoticiasOK()
        {
            //Arrange
            var listaNoticias = new List<Noticia>
            {
                new Noticia { Id = 1, Autor = "Autor01", DataPublicacao = DateTime.Now, Descricao = "Descricao01", Titulo = "Titulo01"},
                new Noticia { Id = 1, Autor = "Autor02", DataPublicacao = DateTime.Now, Descricao = "Descricao02", Titulo = "Titulo02"}
            };

            _noticiaServiceMock.Setup(s => s.GetAllNoticias()).Returns(listaNoticias);

            //Act
            var result = _noticiaController.GetNoticias();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.Equal(listaNoticias, okResult.Value);
        }

        [Fact]
        public void NoticiaPorIdNotFound()
        {
            //Arrange
            Noticia noticia = null;

            _noticiaServiceMock.Setup(s => s.NoticiaPorId(3)).Returns(noticia);
            //Act
            var result = _noticiaController.NoticiaPorId(3);

            //Assert
            Assert.IsType<NotFoundResult>(result);

        }
    }

}
