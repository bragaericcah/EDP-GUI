SELECT * FROM boatreservationdb.payments;

INSERT INTO Payments (payment_id, user_id, reservation_id, amount, payment_method, status) VALUES
(1, 4, 1, 150.00, 'Cash', 'Completed'),
(2, 2, 2, 200.00, 'Cash', 'Pending'),
(3, 7, 3, 190.00, 'Cash', 'Refunded'),
(4, 8, 4, 160.00, 'Cash', 'Completed'),
(5, 5, 5, 135.00, 'Cash', 'Pending'),
(6, 3, 6, 600.00, 'Cash', 'Completed'),
(7, 10, 7, 110.00, 'Cash', 'Refunded'),
(8, 9, 8, 700.00, 'Cash', 'Completed'),
(9, 6, 9, 140.00, 'Cash', 'Pending'),
(10, 1, 10, 900.00, 'Cash', 'Completed');
