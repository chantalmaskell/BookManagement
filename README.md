# PageTurner

## Overview

PageTurner is a simple book management web app built using .NET (C#) and Razor. This app allows users to manage and keep track of their favorite books, similar to the popular Goodreads platform. Users can add, view, update, and remove books from their collection, as well as track their reading progress.

## Features

- Browse and manage your collection of books.
- Add new books to your collection by providing details such as title, author, genre, page count, and book cover image.
- Update your reading progress by indicating the current page number.
- Remove books from your collection when no longer needed.

## Getting Started

1. Clone the repository to your local machine using `git clone`.
2. Open the project in your preferred .NET development environment.
3. Build and run the application.
4. Access the app in your browser by navigating to the provided URL.

## Prerequisites

- .NET SDK (version 7.0 or higher)

## Technologies Used

- .NET Core
- C#
- Razor Pages
- Entity Framework Core
- HTML, CSS, JavaScript (for frontend)
- MySQL or other database (configured in the `appsettings.json` file)

## Usage

1. Start by adding your favorite books to your collection.
2. Provide details such as the book's title, author, genre, page count, and upload an image of the book cover.
3. Update your reading progress by indicating the current page number.
4. View your collection of books with cover images and titles.
5. Remove books from your collection when you're done reading.

## Endpoints (still being updated and tested)

<table>
  <tr>
    <th><b>Request type</th>
    <th><b>Endpoint</th>
  </tr>
  <tr>
    <td>GET</td>
    <td><code>/books</code></td>
  </tr>
<tr>
    <td>GET</td>
    <td><code>/users</code></td>
  </tr>
  <tr>
    <td>POST</td>
    <td><code>/add-book</code></td>
  </tr>
        <tr>
    <td>POST</td>
    <td><code>/add-user</code></td>
  </tr>
<tr>
    <td>PUT</td>
    <td><code>/update-book-status</code></td>
  </tr>
      <tr>
    <td>DELETE</td>
    <td><code>/remove-book</code></td>
  </tr>
</table>
