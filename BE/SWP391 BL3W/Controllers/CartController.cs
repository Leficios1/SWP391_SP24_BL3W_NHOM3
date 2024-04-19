﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO.Request;
using SWP391_BL3W.Services.Interface;

namespace SWP391_BL3W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public ICartService _cartService { get; set; }
        public CartController(ICartService cartService) 
        { 
            this._cartService = cartService;
        }
        [HttpGet("get-by-user-id/{userId}")]
        public async Task<IActionResult> GetByUserId([FromRoute] int userId) 
        {
            var response = await _cartService.GetCartsByUserId(userId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [HttpPut("cart-to-new-order/by-user-id/{userId}")]
        public async Task<IActionResult> CompletedToConvertToOrder([FromRoute] int userId, [FromBody] PaymentDTO paymentDTO)
        {
            var response = await _cartService.CompletedPaymentCartToOrder(userId,paymentDTO);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [HttpPut("update-quantity-by-productid-and-userid/{userId}/{productId}/{quantity}")]
        public async Task<IActionResult> updateCartByProductIdAndUserId([FromRoute] int userId,[FromRoute] int productId,[FromRoute] int quantity)
        {
            var response = await _cartService.UpdateQuantityByProductIdAndUserId(userId,productId, quantity);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [HttpPost("add-product-into-cart")]
        public async Task<IActionResult> AddToCart(CartRequestDTO dto)
        {
            var response = await _cartService.AddProductToCartByUserId(dto);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [HttpDelete("delete-all-carts-by-user-id/{userId}")]
        public async Task<IActionResult> DeleteAllCartsByUserId([FromRoute] int userId)
        {
            var response = await _cartService.DeleteAllProductsInCartByUserId(userId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
        [HttpDelete("delete-product-id-by-user-id/{productId}/{userId}")]
        public async Task<IActionResult> DeleteAllCartsByUserId([FromRoute] int userId,[FromRoute] int productId)
        {
            var response = await _cartService.DeleteProductIdInCartByUserId(userId,productId);
            return StatusCode((int)response.statusCode, new { data = response.Data, message = response.Errormessge });
        }
    }
}