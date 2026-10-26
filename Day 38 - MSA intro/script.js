// ==========================================================
// ShopEase - home page behaviour
// ==========================================================

// Sample catalogue. Replace with data from your API later.
const products = [
    { id: 1, name: "Classic Analog Watch", category: "Fashion", price: 129, oldPrice: 179, tag: "Best seller", img: "https://images.unsplash.com/photo-1523275335684-37898b6baf30?auto=format&fit=crop&w=600&q=80" },
    { id: 2, name: "Urban Denim Jacket", category: "Fashion", price: 89, oldPrice: null, tag: "New", img: "https://images.unsplash.com/photo-1576995853123-5a10305d93c0?auto=format&fit=crop&w=600&q=80" },
    { id: 3, name: "Air Runner Sneakers", category: "Footwear", price: 110, oldPrice: 140, tag: "Sale", img: "https://images.unsplash.com/photo-1542291026-7eec264c27ff?auto=format&fit=crop&w=600&q=80" },
    { id: 4, name: "Wireless Headphones", category: "Electronics", price: 149, oldPrice: 199, tag: "Sale", img: "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?auto=format&fit=crop&w=600&q=80" },
    { id: 5, name: "Leather Ankle Boots", category: "Footwear", price: 165, oldPrice: null, tag: "New", img: "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?auto=format&fit=crop&w=600&q=80" },
    { id: 6, name: "Smart Fitness Band", category: "Electronics", price: 79, oldPrice: 99, tag: "Sale", img: "https://images.unsplash.com/photo-1575311373937-040b8e1fd5b6?auto=format&fit=crop&w=600&q=80" },
    { id: 7, name: "Minimalist Table Lamp", category: "Home", price: 58, oldPrice: null, tag: "Trending", img: "https://images.unsplash.com/photo-1507473885765-e6ed057f782c?auto=format&fit=crop&w=600&q=80" },
    { id: 8, name: "Ceramic Vase Set", category: "Home", price: 45, oldPrice: 60, tag: "Sale", img: "https://images.unsplash.com/photo-1578500494198-246f612d3b3d?auto=format&fit=crop&w=600&q=80" }
];

const productGrid = document.getElementById("productGrid");
const emptyMsg = document.getElementById("emptyMsg");
const filterTabs = document.getElementById("filterTabs");
const searchToggle = document.getElementById("searchToggle");
const searchBar = document.getElementById("searchBar");
const searchInput = document.getElementById("searchInput");
const menuToggle = document.getElementById("menuToggle");
const navLinks = document.getElementById("navLinks");
const cartCount = document.getElementById("cartCount");
const toast = document.getElementById("toast");
const subscribeForm = document.getElementById("subscribeForm");
const emailInput = document.getElementById("emailInput");
const formMsg = document.getElementById("formMsg");

let activeCategory = "All";
let cartItems = Number(localStorage.getItem("shopease-cart")) || 0;
let toastTimer;

// ---------- Helpers ----------
function formatPrice(value) {
    return "$" + value.toFixed(2);
}

function showToast(message) {
    toast.textContent = message;
    toast.classList.add("show");
    clearTimeout(toastTimer);
    toastTimer = setTimeout(() => toast.classList.remove("show"), 2200);
}

function updateCartCount() {
    cartCount.textContent = cartItems;
    cartCount.classList.add("bump");
    setTimeout(() => cartCount.classList.remove("bump"), 200);
    localStorage.setItem("shopease-cart", cartItems);
}

// ---------- Product rendering ----------
function createProductCard(product) {
    const card = document.createElement("article");
    card.className = "product-card reveal";

    const tagClass = product.tag === "Sale" ? "product-tag sale" : "product-tag";
    const oldPriceHtml = product.oldPrice
        ? `<span class="old-price">${formatPrice(product.oldPrice)}</span>`
        : "";

    // If the image fails to load, the gradient background of .product-img shows instead
    card.innerHTML = `
        <div class="product-img">
            <img src="${product.img}" alt="${product.name}" loading="lazy" onerror="this.style.display='none'">
            <span class="${tagClass}">${product.tag}</span>
        </div>
        <div class="product-info">
            <span class="product-cat">${product.category}</span>
            <h3>${product.name}</h3>
            <div class="price-row">
                <span class="price">${formatPrice(product.price)}</span>
                ${oldPriceHtml}
            </div>
            <button class="add-btn" type="button">Add to Cart</button>
        </div>
    `;

    card.querySelector(".add-btn").addEventListener("click", () => {
        cartItems++;
        updateCartCount();
        showToast(`${product.name} added to cart`);
    });

    return card;
}

function renderProducts() {
    const query = searchInput.value.trim().toLowerCase();

    const filtered = products.filter(product => {
        const matchesCategory = activeCategory === "All" || product.category === activeCategory;
        const matchesSearch = product.name.toLowerCase().includes(query)
            || product.category.toLowerCase().includes(query);
        return matchesCategory && matchesSearch;
    });

    productGrid.innerHTML = "";
    filtered.forEach(product => productGrid.appendChild(createProductCard(product)));

    emptyMsg.hidden = filtered.length > 0;
    observeReveals(productGrid.querySelectorAll(".reveal"));
}

function setCategory(category) {
    activeCategory = category;
    document.querySelectorAll(".tab").forEach(tab => {
        tab.classList.toggle("active", tab.dataset.filter === category);
    });
    renderProducts();
}

// ---------- Filters & search ----------
filterTabs.addEventListener("click", event => {
    const tab = event.target.closest(".tab");
    if (tab) setCategory(tab.dataset.filter);
});

// Category cards filter the product list too
document.querySelectorAll(".category-card[data-category]").forEach(card => {
    card.addEventListener("click", () => setCategory(card.dataset.category));
});

searchToggle.addEventListener("click", () => {
    searchBar.classList.toggle("open");
    if (searchBar.classList.contains("open")) {
        searchInput.focus();
    }
});

searchBar.addEventListener("submit", event => event.preventDefault());
searchInput.addEventListener("input", () => {
    if (searchInput.value.trim() && activeCategory !== "All") {
        // Searching across all categories is more intuitive
        activeCategory = "All";
        document.querySelectorAll(".tab").forEach(tab => {
            tab.classList.toggle("active", tab.dataset.filter === "All");
        });
    }
    renderProducts();
});

// ---------- Mobile menu ----------
menuToggle.addEventListener("click", () => {
    const isOpen = navLinks.classList.toggle("open");
    menuToggle.classList.toggle("open", isOpen);
    menuToggle.setAttribute("aria-expanded", String(isOpen));
});

// Close the mobile menu after picking a link
navLinks.querySelectorAll("a").forEach(link => {
    link.addEventListener("click", () => {
        navLinks.classList.remove("open");
        menuToggle.classList.remove("open");
        menuToggle.setAttribute("aria-expanded", "false");
    });
});

// ---------- Newsletter ----------
subscribeForm.addEventListener("submit", event => {
    event.preventDefault();
    const email = emailInput.value.trim();
    const isValid = /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email);

    emailInput.classList.toggle("invalid", !isValid);
    formMsg.classList.toggle("error", !isValid);
    formMsg.classList.toggle("success", isValid);

    if (isValid) {
        formMsg.textContent = "Thanks for subscribing! Check your inbox for your 10% code.";
        subscribeForm.reset();
    } else {
        formMsg.textContent = "Please enter a valid email address.";
    }
});

// ---------- Scroll reveal animation ----------
const revealObserver = new IntersectionObserver((entries, observer) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.classList.add("visible");
            observer.unobserve(entry.target);
        }
    });
}, { threshold: 0.12 });

function observeReveals(elements) {
    elements.forEach(el => revealObserver.observe(el));
}

// ---------- Init ----------
document.getElementById("year").textContent = new Date().getFullYear();
updateCartCount();
renderProducts();
observeReveals(document.querySelectorAll(".reveal:not(.visible)"));
