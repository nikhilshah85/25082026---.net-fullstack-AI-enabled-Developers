# Base image: a small nginx web server on Alpine Linux
FROM nginx:stable-alpine

# Documentation only: nginx listens on port 80 inside the container
EXPOSE 80

# Remove nginx's default welcome page
RUN rm -rf /usr/share/nginx/html/*

# Copy our website files into the folder nginx serves
COPY home.html styles.css script.js /usr/share/nginx/html/

# nginx serves index.html for "/", so give home.html that name too
RUN cp /usr/share/nginx/html/home.html /usr/share/nginx/html/index.html

# nginx's base image already starts nginx, so no CMD is needed
