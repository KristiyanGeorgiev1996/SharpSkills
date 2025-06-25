# HTTP Basics

This lecture presents the basics of the HTTP protocol and how communication between client and server works in web applications. It is essential for anyone who wants to understand how browsers, servers, and the internet interact.

---

## 🔗 What is HTTP?

HTTP (HyperText Transfer Protocol) is a text-based request-response protocol used on the Internet. It allows a client (e.g., browser) to request a resource from a server (e.g., HTML page, image, database data) via a URL.

- Widely used for web applications.
- Works on a client-server principle.
- Stateless (does not maintain session state).
- Often combined with HTTPS (secure HTTP).

---

## 🧭 Front-end vs Back-end

- **Front-end (client-side):** The UI built with HTML, CSS, JS (e.g., React) that users see.
- **Back-end (server-side):** Logic, data, and services (e.g., API with ASP.NET Core).
- HTTP is the *bridge* between them — front-end sends requests, back-end returns responses.

---

## 🛠️ HTTP Developer Tools

In Google Chrome, press `F12` → Network tab to:

- Track HTTP requests sent by the site.
- See methods (GET, POST…), status codes (200, 404…), responses, and headers.
- Debug requests, forms, and API communication.

You can also use tools like **Postman** to manually send and analyze HTTP requests.

---

## 📝 HTML Forms and HTTP

HTML forms send data to the server via HTTP.

- The `action` attribute defines where data is sent.
- The `method` attribute defines how data is sent – `GET` (in URL) or `POST` (in request body).

---

📤 HTTP Request
Consists of:

 - Method – what the client wants (GET, POST, PUT…)
 - URL – what resource is requested
 - Headers – additional info (e.g., content type)
 - Body – data sent (if any, e.g., POST)

---

📥 HTTP Response
Consists of:

 - Status code – success or failure (200 OK, 404 Not Found…)
 - Headers – content type, length, etc.
 - Body – content (e.g., HTML, JSON)

---

✅ HTTP Methods and When to Use Them

| Method  | Description                 | When to Use                                            |
|---------|-----------------------------|-------------------------------------------------------|
| GET     | Retrieve (read) a resource  | When you want to fetch data from the server           |
| POST    | Create a new resource       | When registering, adding comments, or sending data    |
| PUT     | Replace an entire resource  | When you want to overwrite a whole object (e.g., profile) |
| PATCH   | Partially update a resource | When updating only part of the data (e.g., email only)|
| DELETE  | Delete a resource           | To remove records (e.g., delete a product/user)       |
| HEAD    | Retrieve only headers       | For checking, without loading the content              |
| OPTIONS | Return supported methods    | Used in CORS preflight requests                        |

---

🌍 URL Structure
A URL contains:

http://mysite.com:8080/demo/index.php?id=27&lang=en#lectures
 - Protocol: http or https
 - Host: mysite.com
 - Port: 8080 (default: 80)
 - Path: /demo/index.php
 - Query string: ?id=27&lang=en (parameters)
 - Fragment: #lectures (page section)

---

🔠 URL Encoding
URLs can contain only certain characters. Others must be encoded:

| Character | Encoding |
|-----------|----------|
| space     | %20      |
| &         | %26      |
| щ         | %D1%89   |
| 爱        | %E7%88%B1 |

---

📌 Conclusion
HTTP is the foundation of web communication.

 - Requests and responses contain method, URL, headers, and body.
 - HTML forms and tools like Postman help testing.
 - Understanding HTTP methods and response status codes is key for any web system.
 - It's important to distinguish between GET, POST, PUT, PATCH, etc.

