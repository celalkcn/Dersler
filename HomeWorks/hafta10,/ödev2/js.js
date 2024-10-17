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