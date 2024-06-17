var clickButton = ()=>{
    fetch('https://dummyjson.com/products', {
        method: 'GET',
    })
.then(async(res) => {
    var productCard = document.getElementById("product-card");
    var products= await res.json()
    var data=""
    // productCard.innerHTML= (products.products.forEach(product=>{
    //     data+=
    //     `<div class="card" style="width: 18rem;">
    //         <img src="..." class="card-img-top" alt="...">
    //         <div class="card-body">
    //           <h5 class="card-title">`+product.title+`</h5>
    //           <p class="">`+product.description+`</p>
    //         </div>
    //         <ul class="list-group list-group-flush">
    //           <li class="list-group-item">`+product.category+`</li>
    //           <li class="list-group-item">`+product.price+`</li>
    //           <li class="list-group-item">`+product.rating+`</li>
    //         </ul>
    //         <div class="card-body">
    //           <a href="#" class="card-link">Card link</a>
    //           <a href="#" class="card-link">Another link</a>
    //         </div>
    //       </div>`
    // })
    // )
    var cardsHTML = products.products.map(product => {
        return `
        <div class="card" style="width: auto;">
            <img src="${product.thumbnail}" class="card-img-top" alt="Placeholder Image">
            <div class="card-body">
                <h5 class="card-title">${product.title}</h5>
                <p class="card-text">${product.description}</p>
                <div class="card-text">${product.category}</div>
                <div class="card-text">${product.price}</div>
                <div class="card-text">${product.rating}</div>
            </div>
            <ul class="list-group list-group-flush">
                <li class="list-group-item"><span class="fw-bold">Category:</span> ${product.category}</li>
                <li class="list-group-item"><span class="fw-bold">Price:</span> ${product.price}</li>
                <li class="list-group-item"><span class="fw-bold">Rating:</span> ${product.rating}</li>
            </ul>
            <div class="card-body" style="column-gap:4px;padding:4px 4px;">
            <button style="border-radius:50px; padding: 4px 16px; border:none;">${product.tags[0]?product.tags[0]:""}</button>
            <button style="border-radius:50px; padding: 4px 16px; border:none;">${product.tags[1]?product.tags[1]:""}</button>
            </div>
        </div>
        `;
    });

    productCard.innerHTML = cardsHTML.join('');
})
.catch(error => {
    console.error(error);
});
}

