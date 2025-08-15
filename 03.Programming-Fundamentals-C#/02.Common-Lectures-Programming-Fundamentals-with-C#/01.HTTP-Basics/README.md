# HTTP Basics

![HTTP](Images/HTTP.jpg)

**HTTP (HyperText Transfer Protocol)** is the main protocol for exchanging information on the Internet.  
It works on a **client–server** model: the client (e.g., a browser) sends a request via **URL**, and the server returns the resource or an error message.  

- ⚡ **Stateless** – each request is processed independently.  
- 🔒 Often combined with **HTTPS** for secure communication.

---

## 🧭 Front-end vs Back-end

- **Front-end (client-side)** – HTML, CSS, JavaScript, or frameworks like React; this is what the user interacts with.  
- **Back-end (server-side)** – logic, databases, and APIs that handle requests.  
- HTTP is the **bridge for communication** between them.

---

## 📤 HTTP Requests

HTTP requests include:  
- **Method** – GET, POST, PUT, PATCH, DELETE, etc.  
- **URL** – resource address.  
- **Headers** – additional information.  
- **Body** – optional content (e.g., for POST or PUT).

---

## 📥 HTTP Responses

HTTP responses include:  
- **Status code** – success or error (e.g., 200 OK, 404 Not Found).  
- **Headers** – metadata about the response.  
- **Body** – content (HTML, JSON, etc.).

---

## 📝 HTML Forms

- **action** – the URL where data is sent.  
- **method** – the way data is sent:  
  - **GET** – appends data to the URL.  
  - **POST** – sends data in the request body.

---

## 🛠️ Developer Tools

- **Network tab** in the browser – track requests, methods, status codes, and headers.  
- **Postman** – manually test and analyze HTTP requests.

---

## 🌍 URL Structure

- **Protocol** – http/https  
- **Host** – domain name  
- **Port** – port number (default HTTP: 80, HTTPS: 443)  
- **Path** – path to the resource  
- **Query string** – parameters (e.g., `?id=27&lang=en`)  
- **Fragment** – specific section of the page (`#lectures`)  

- 🔠 **URL encoding** – special characters must be encoded (e.g., space → %20, & → %26).

---

## 📌 Conclusion

Understanding **HTTP** is essential for any web development because all web applications rely on exchanging requests and responses between the client and server.
