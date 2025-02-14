# Cinema Management System

## Overview

This repository contains a comprehensive Movie Management System designed to handle various aspects of a movie theater, including movie and genre management, staff and customer management, room and concession management, and payment processing. The system is built to provide an efficient and user-friendly interface for managing all these components seamlessly.

## Features

- **Movies and Genres Management**: Add, update, delete, and view movies and their associated genres.
- **Staff Management**: Manage staff members, including their roles and associated managers.
- **Customers and Tickets Management**: Handle customer information and ticket sales.
- **Rooms and Concessions Management**: Manage theater rooms and concession items.
- **Payments Management**: Process and track payments for tickets and concessions.

## Getting Started

### Prerequisites

- Ensure you have a compatible database system installed (e.g., MySQL, PostgreSQL).
- Install any necessary dependencies listed in the `requirements.txt` file.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/movie-management-system.git
   ```
2. Navigate to the project directory:
   ```bash
   cd movie-management-system
   ```
3. Install the required dependencies:
   ```bash
   pip install -r requirements.txt
   ```
4. Set up your database and configure the connection settings in the `config.py` file.
5. Run the application:
   ```bash
   python main.py
   ```

## Usage

### Start Menu

- **Start**: Begin using the application.
- **Begin Menu**: Access various management sections:
  - **Movies and Genres Management**
  - **Staff Management**
  - **Customers and Tickets Management**
  - **Rooms and Concessions Management**
  - **Payments Management**

### Managing Movies and Genres

- **Insert**: Add new movies and genres.
- **Update**: Modify existing movie and genre details.
- **Delete**: Remove movies and genres from the system.
- **Select**: View specific movie and genre details.
- **View**: Display a list of all movies and genres.

### Managing Staff

- **Insert**: Add new staff members.
- **Update**: Modify staff details.
- **Delete**: Remove staff members from the system.
- **Select**: View specific staff details.
- **View**: Display a list of all staff members.

### Managing Customers and Tickets

- **Insert**: Add new customers and ticket records.
- **Update**: Modify customer and ticket details.
- **Delete**: Remove customers and tickets from the system.
- **Select**: View specific customer and ticket details.
- **View**: Display a list of all customers and tickets.

### Managing Rooms and Concessions

- **Insert**: Add new rooms and concession items.
- **Update**: Modify room and concession details.
- **Delete**: Remove rooms and concessions from the system.
- **Select**: View specific room and concession details.
- **View**: Display a list of all rooms and concessions.

### Managing Payments

- **Insert**: Add new payment records.
- **Update**: Modify payment details.
- **Delete**: Remove payments from the system.
- **Select**: View specific payment details.
- **View**: Display a list of all payments.

## Database Schema

The database schema includes tables for movies, genres, actors, directors, staff, customers, tickets, rooms, concessions, and payments. Below is a brief overview of the main tables:

- **Movies**: `movie_id`, `title`, `type`, `duration`, `description`, `trailer_link`, `director_id`, `genera_id`
- **Actors**: `actor_id`, `first_name`, `last_name`
- **Directors**: `director_id`, `first_name`, `last_name`
- **Staff**: `staff_id`, `name`, `role`, `manager_id`
- **Customers**: `customer_id`, `name`, `email`, `phone`
- **Tickets**: `ticket_id`, `price`, `purchase_date`, `payment_method`, `customer_id`, `booth_id`
- **Rooms**: `room_id`, `name`, `total_seats`
- **Concessions**: `item_id`, `name`, `price`, `stock_quantity`
- **Payments**: `payment_id`, `ticket_id`, `payment_date`, `amount`, `payment_method`

