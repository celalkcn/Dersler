$(document).ready(() => {

    getPosts();

})

function getPosts() {
    $.ajax({
        url: "https://fakestoreapi.com/products",
        method: "GET",
        success: function (res) {
            res.forEach(item => {
                $("#posts").append(`
                    <div class="col-3 mb-3">
                        <div class="card">
                            <img src="${item.image}" class="card-img-top" alt="${item.title}">
                            <div class="card-body">
                                <h5 class="card-title">${item.title}</h5>
                                <p class="card-text">${item.description}</p>
                                <p class="card-text"><strong>Price: $${item.price}</strong></p>
                                <a href="#" class="card-link">Card link</a>
                                <a href="#" class="card-link">Another link</a>
                            </div>
                        </div>
                    </div>
                `);
            });
        },
        error: function (err) {
            console.error("Error fetching data", err);
        }
    });
}





 // buracı chat gpt den toplam quantity kısmını gösteriyor...   
// $(document).ready(() => {
//     getProductsAndQuantities();
// });

// function getProductsAndQuantities() {
//     $.ajax({
//         url: "https://fakestoreapi.com/products",
//         method: "GET",
//         success: function (products) {
//             $.ajax({
//                 url: "https://fakestoreapi.com/carts",
//                 method: "GET",
//                 success: function (carts) {
//                     // Kartlardan toplam quantity'leri doğrudan hesapla
//                     const totalQuantities = {};

//                     carts.forEach(cart => {
//                         cart.products.forEach(product => {
//                             const productId = product.productId;
//                             const quantity = product.quantity;

//                             // Toplam quantity'yi doğrudan ekle
//                             if (totalQuantities[productId]) {
//                                 totalQuantities[productId] += quantity;
//                             } else {
//                                 totalQuantities[productId] = quantity;
//                             }
//                         });
//                     });

//                     // Ürün kartlarını oluştur
//                     products.forEach(item => {
//                         // Doğrudan quantity'yi al
//                         const totalQuantity = totalQuantities[item.id] || 0;

//                         $("#posts").append(`
// <div class="col-3 mb-3">
//     <div class="card">
//         <img src="${item.image}" class="card-img-top" alt="${item.title}">
//         <div class="card-body">
//             <h5 class="card-title">${item.title}</h5>
//             <p class="card-text">${item.description}</p>
//             <p class="card-text"><strong>Price: $${item.price}</strong></p>
//             <p class="card-text"><strong>Total Quantity: ${totalQuantity}</strong></p>
//             <a href="#" class="card-link">Card link</a>
//             <a href="#" class="card-link">Another link</a>
//         </div>
//     </div>
// </div>
// `);
//                     });
//                 },
//                 error: function (err) {
//                     console.error("Error fetching cart data", err);
//                 }
//             });
//         },
//         error: function (err) {
//             console.error("Error fetching product data", err);
//         }
//     });
// }