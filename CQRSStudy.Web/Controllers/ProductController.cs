using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Commands.Product.Request;
using CQRSStudy.BusinessLayer.CQRSWithMediatorPattern.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSStudy.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Buradaki yoðunluðu ortadan kaldýrmak adýna Mediator Pattern kullanacaðýz.

        #region BeforeMediatorPattern
        // CreateProductCommandHandler _createProductCommandHandler;
        // DeleteProductCommandHandler _deleteProductCommandHandler;
        // GetAllProductQueryHandler _getAllProductQueryHandler;
        // GetByIdProductQueryHandler _getByIdProductQueryHandler;
        // public ProductController(
        //     CreateProductCommandHandler createProductCommandHandler,
        //     DeleteProductCommandHandler deleteProductCommandHandler,
        //     GetAllProductQueryHandler getAllProductQueryHandler,
        //     GetByIdProductQueryHandler getByIdProductQueryHandler)
        // {
        //     _createProductCommandHandler = createProductCommandHandler;
        //     _deleteProductCommandHandler = deleteProductCommandHandler;
        //     _getAllProductQueryHandler = getAllProductQueryHandler;
        //     _getByIdProductQueryHandler = getByIdProductQueryHandler;
        // }
           
        // [HttpGet]
        // public IActionResult Get([FromQuery] GetAllProductQueryRequest requestModel)
        // {
        //     List<GetAllProductQueryResponse> allProducts = _getAllProductQueryHandler.GetAllProduct(requestModel);
        //     return Ok(allProducts);
        // }
           
        // [HttpGet("{id}")]
        // public IActionResult Get([FromQuery] GetByIdProductQueryRequest requestModel)
        // {
        //     GetByIdProductQueryResponse product = _getByIdProductQueryHandler.GetByIdProduct(requestModel);
        //     return Ok(product);
        // }
           
        // [HttpPost]
        // public IActionResult Post([FromBody] CreateProductCommandRequest requestModel)
        // {
        //     CreateProductCommandResponse response = _createProductCommandHandler.CreateProduct(requestModel);
        //     return Ok(response);
        // }
           
        // [HttpDelete("{id}")]
        // public IActionResult Delete([FromQuery] DeleteProductCommandRequest requestModel)
        // {
        //     DeleteProductCommandResponse response = _deleteProductCommandHandler.DeleteProduct(requestModel);
        //     return Ok(response);
        // } 
        #endregion

        #region AfterMediatorPattern
        IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest requestModel)
        {
            var allProducts = await _mediator.Send(requestModel);
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] GetByIdProductQueryRequest requestModel)
        {
            var product = await _mediator.Send(requestModel);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest requestModel)
        {
            var response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteProductCommandRequest requestModel)
        {
            var response = await _mediator.Send(requestModel);
            return Ok(response);
        }
        #endregion
    }
}
