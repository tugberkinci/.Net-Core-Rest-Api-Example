## .Net-Core-Rest-Api-Example
-Rest api example that fetching images from Unsplash.com.
-We have two API in this project;

## Search API (.../api_base/search)

-That api searches images from given query parameter from unsplash.com.
-Requires http body parameter;
-First one is "per_page", that is integer value required and fetching that number of latest images.
-Second one is "query", that is what we want to search on unsplash.com.

-Example query is like that ;
-http://localhost:..../api_base/search
{
"per_page":4,
"query":"flower"
}

-And response of the this request in postman;
-{
 -   "Images": {
 -       "img1_URL": "https://images.unsplash.com/photo-1639323921219-23a3002dbf69?-----crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHNlYXJjaHwxfHxmbG93ZXJ8ZW58MHx8Mnx8MTYzOTM0NzQ1NQ&ixlib=rb-1.2.1&q=85",
-        "img2_URL": "https://images.unsplash.com/photo-1639333708533-532e2b6d17ff?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHNlYXJjaHwyfHxmbG93ZXJ8ZW58MHx8Mnx8MTYzOTM0NzQ1NQ&ixlib=rb-1.2.1&q=85",
-        "img3_URL": "https://images.unsplash.com/photo-1639333708537-34d912d5aed4?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHNlYXJjaHwzfHxmbG93ZXJ8ZW58MHx8Mnx8MTYzOTM0NzQ1NQ&ixlib=rb-1.2.1&q=85",
-      "img4_URL": "https://images.unsplash.com/photo-1639333709251-136aa8361fc7?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHNlYXJjaHw0fHxmbG93ZXJ8ZW58MHx8Mnx8MTYzOTM0NzQ1NQ&ixlib=rb-1.2.1&q=85"
-    }
-}

## Random API(.../api_base/random)

-That api fetching random images from unsplash.com.
-Requires http query parameter for how many random images we requires.

-Example api request is like that ;
-http://localhost:..../api_base/random?limit=5

-And response of the this request in postman;

-{
-  "Images": {
-        "img1_URL": "https://images.unsplash.com/photo-1637275731582-e3043d18a8cb?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHJhbmRvbXx8fHx8fHx8fDE2MzkzNDc3NDM&ixlib=rb-1.2.1&q=85",
-        "img2_URL": "https://images.unsplash.com/photo-1637275731582-e3043d18a8cb?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHJhbmRvbXx8fHx8fHx8fDE2MzkzNDc3NDM&ixlib=rb-1.2.1&q=85",
-        "img3_URL": "https://images.unsplash.com/photo-1637275731582-e3043d18a8cb?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHJhbmRvbXx8fHx8fHx8fDE2MzkzNDc3NDM&ixlib=rb-1.2.1&q=85",
-        "img4_URL": "https://images.unsplash.com/photo-1637275731582-e3043d18a8cb?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHJhbmRvbXx8fHx8fHx8fDE2MzkzNDc3NDM&ixlib=rb-1.2.1&q=85",
-        "img5_URL": "https://images.unsplash.com/photo-1637275731582-e3043d18a8cb?crop=entropy&cs=srgb&fm=jpg&ixid=MnwyODIxMjd8MHwxfHJhbmRvbXx8fHx8fHx8fDE2MzkzNDc3NDM&ixlib=rb-1.2.1&q=85"
-    }
-}
