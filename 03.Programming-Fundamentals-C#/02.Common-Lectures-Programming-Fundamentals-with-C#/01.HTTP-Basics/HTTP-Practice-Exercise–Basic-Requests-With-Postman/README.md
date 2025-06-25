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
```
{
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

