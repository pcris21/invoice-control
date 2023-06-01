using AutoMapper;
using Invoice.Control.Api.Requests;
using Invoice.Control.Domain.Entities;
using Invoice.Control.Domain.Interfaces.UseCases.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.Control.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class CustomerController : ControllerBase
    {
        private readonly ICreateCustomer _createCustomerUseCase;
        private readonly IUpdateCustomer _updateCustomerUseCase;
        private readonly IGetCustomer _getCustomerUseCase;
        private readonly IDisableCustomer _disableCustomerUseCase;
        private readonly IMapper _mapper;
        public CustomerController(ICreateCustomer createCustomerUseCase, 
            IUpdateCustomer updateCustomerUseCase, 
            IGetCustomer getCustomerUseCase, 
            IDisableCustomer disableCustomerUseCase, 
            IMapper mapper)
        {
            _createCustomerUseCase = createCustomerUseCase;
            _updateCustomerUseCase = updateCustomerUseCase;
            _getCustomerUseCase = getCustomerUseCase;
            _disableCustomerUseCase = disableCustomerUseCase;
            _mapper = mapper;
        }
       
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Create([FromBody] CustomerRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            var customerEntity = _mapper.Map<Customer>(model);

            var result =  await _createCustomerUseCase.ExecuteAsync(customerEntity);

            if (result.IsFailed)
                return BadRequest(result.Errors);

            return Ok(result.IsSuccess);
            
        }
    }
}
