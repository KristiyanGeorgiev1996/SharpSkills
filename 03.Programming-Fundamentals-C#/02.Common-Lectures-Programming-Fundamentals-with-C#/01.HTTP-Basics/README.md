# HTTP Basics

![HTTP](Images/HTTP.jpg)

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

## 📤 HTTP Request
Consists of:

 - Method – what the client wants (GET, POST, PUT…)
 - URL – what resource is requested
 - Headers – additional info (e.g., content type)
 - Body – data sent (if any, e.g., POST)

---

## 📥 HTTP Response
Consists of:

 - Status code – success or failure (200 OK, 404 Not Found…)
 - Headers – content type, length, etc.
 - Body – content (e.g., HTML, JSON)

---

## ✅ HTTP Methods and When to Use Them

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

## 🌍 URL Structure
A URL contains:

http://mysite.com:8080/demo/index.php?id=27&lang=en#lectures
 - Protocol: http or https
 - Host: mysite.com
 - Port: 8080 (default: 80)
 - Path: /demo/index.php
 - Query string: ?id=27&lang=en (parameters)
 - Fragment: #lectures (page section)

---

## 🔠 URL Encoding
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

--- 

# 🧪 HTTP Practice Exercise – Basic Requests with Postman

This exercise guides you through making basic HTTP requests using [Postman](https://www.postman.com/). You'll learn how to work with GET, POST, DELETE, and PATCH methods by interacting with a Firebase-based API.

---

## 🔧 Prerequisites

- Install Postman: [Download here](https://www.postman.com/downloads/)
- Basic knowledge of HTTP (GET, POST, PATCH, DELETE)

---

## 📌 API Base URL

All requests go to the Firebase endpoint:

https://trips-48955.firebaseio.com/trips.json


---

## 1️⃣ Get All Trips

Make a **GET** request to list all available trips:

GET https://trips-48955.firebaseio.com/trips.json


🟢 **Expected Result**: A JSON list of all trips currently stored in the Firebase database.

📸 **Screenshot Tip**: Take a screenshot of the request in Postman and the response body in JSON format.

---

## 2️⃣ Create a New Trip

Make a **POST** request to add a new trip.

**Request URL**:
POST https://trips-48955.firebaseio.com/trips.json


**Request Body (JSON):**
```json
{
  "description": "October-November and February-March are the best times to see the northern lights. Dark skies yield better displays – avoid full moon.",
  "imagePath": "https://www.aurora-nights.co.uk/wp-content/uploads/2019/07/norway-northern-lights-1500x587_c.jpg",
  "name": "Capture the Northern Lights on camera"
}
```
🟢 Expected Result: A unique postId is returned by Firebase in the response body.

📸 Screenshot Tip: Take a screenshot of the request, body, and response postId.

---

Use the postId returned from the previous step to delete the newly created trip.

Request URL  (replace {postId}):
DELETE https://trips-48955.firebaseio.com/trips/{postId}.json

## 3️⃣ Delete the Trip
🟢 Expected Result: Status code 200 OK, and response body null.

📸 Screenshot Tip: Show the request, the DELETE action, and the confirmation response.

---

## 4️⃣ Edit an Existing Trip
Now perform a PATCH request to update an existing trip.

Request URL:
PATCH https://trips-48955.firebaseio.com/trips/-MIJ0HydEYF0x6fljO55.json

Request Body (JSON):
```{
  "description": "Egypt welcomes you!",
  "imagePath": "https://www.karacitours.bg/public/thumbs/767x341/egipet/egipet-4_767x341_crop_542eb8694d.jpg",
  "name": "Pyramids of Giza, Egypt",
  "edit": "true"
}
```

🟢 Expected Result: The JSON object is updated with the new values.

📸 Screenshot Tip: Show the patch request with updated content and the new response data.

---

✅ Summary
Method	Action	URL format
GET	Get all trips	https://.../trips.json
POST	Create new trip	https://.../trips.json + JSON body
DELETE	Remove trip	https://.../trips/{postId}.json
PATCH	Update trip partially	https://.../trips/{postId}.json + partial JSON body

