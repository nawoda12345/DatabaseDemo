
-- Update an order to use the discount
UPDATE orders
SET discount_code_id = 1  -- referencing discount_codes.discount_code_id
WHERE order_id = 1;
