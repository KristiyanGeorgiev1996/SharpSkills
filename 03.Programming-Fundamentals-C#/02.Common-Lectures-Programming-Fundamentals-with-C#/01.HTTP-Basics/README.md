# HTTP Basics

![HTTP](Images/HTTP.jpg)

This lecture explains the core ideas behind the HTTP protocol and how browsers and servers exchange information in web applications. A solid understanding of this process is vital for anyone learning how the web works under the hood.

---

## 🔗 Understanding HTTP

**HTTP (HyperText Transfer Protocol)** is a text-based, request–response protocol used to transfer data across the internet.  
A client (e.g., a browser) sends a request to a server (e.g., for an HTML page, an image, or database data) via a **URL**, and the server responds with the requested resource or an error.

- Commonly used in all web applications.
- Operates on the client–server model.
- **Stateless** – each request is processed independently without storing previous state.
- Often paired with **HTTPS** for encryption and security.

---

## 🧭 Front-end vs. Back-end

- **Front-end (client side)** – the user interface built with HTML, CSS, and JavaScript (or frameworks like React) that the user directly interacts with.
- **Back-end (server side)** – the logic, data storage, and APIs that power the application, often implemented with technologies like ASP.NET Core.
- HTTP acts as the **communication bridge** — the front-end sends requests, the back-end provides responses.

---

## 🛠️ Developer Tools for HTTP

In Google Chrome, press `F12` and open the **Network** tab to:

- Inspect all HTTP requests sent by a web page.
- Check methods (GET, POST…), status codes (200, 404…), and headers.
- Debug forms, API requests, and responses.

You can also use tools like **Postman** to send and analyze HTTP requests manually.

---

## 📝 HTML Forms and HTTP

HTML forms communicate with servers using HTTP:

- `action` – defines the destination URL for the data.
- `method` – defines how the data is sent:
  - **GET** – appends data to the URL.
  - **POST** – sends data in the request body.

---

## 📤 Structure of an HTTP Request

An HTTP request usually contains:

- **Method** – action type (GET, POST, PUT…)
- **URL** – the resource location
- **Headers** – extra information (e.g., content type)
- **Body** – optional data payload (used with POST, PUT, PATCH)

---

## 📥 Structure of an HTTP Response

An HTTP response typically includes:

- **Status code** – indicates success or failure (200 OK, 404 Not Found…)
- **Headers** – metadata about the response (e.g., content type, content length)
- **Body** – the actual content (HTML, JSON, etc.)

---

## ✅ Common HTTP Methods

| Method  | Purpose                     | Typical Use Case                                          |
|---------|-----------------------------|-----------------------------------------------------------|
| GET     | Retrieve a resource         | Fetch data without modifying it                          |
| POST    | Create a new resource       | Submit forms, add comments, register users               |
| PUT     | Replace an existing resource| Fully update a record (e.g., change a profile)           |
| PATCH   | Partially update a resource | Update a single field without replacing the whole object |
| DELETE  | Remove a resource           | Delete a record, file, or entry                          |
| HEAD    | Get only headers            | Check resource info without downloading the body         |
| OPTIONS | List supported methods      | Used in CORS preflight checks                            |

---

## 🌍 URL Components

Example:  
`http://mysite.com:8080/demo/index.php?id=27&lang=en#lectures`

- **Protocol** – `http` or `https`
- **Host** – `mysite.com`
- **Port** – `8080` (default HTTP: 80, HTTPS: 443)
- **Path** – `/demo/index.php`
- **Query string** – `?id=27&lang=en` (parameters)
- **Fragment** – `#lectures` (specific section of a page)

---

## 🔠 URL Encoding

Only certain characters are allowed in URLs. Others must be encoded:

| Character | Encoding |
|-----------|----------|
| space     | %20      |
| &         | %26      |
| щ         | %D1%89   |
| 爱        | %E7%88%B1 |

---

## 📌 Summary

- HTTP is the backbone of web communication.
- Every request and response contains a method, a URL, headers, and optionally a body.
- HTML forms and tools like Postman make it easier to test requests.
- Understanding the difference between GET, POST, PUT, PATCH, and other methods is key to building any web application.

---
