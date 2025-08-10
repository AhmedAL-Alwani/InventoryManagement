-- ===============================
-- STORED PROCEDURES FOR: Transactions form
-- AUTHOR: des_des
-- CREATED: 2025-08-07
-- ===============================



-- ÏÇבו ÊÚםÏ ÑÞד ÇבÕהÝ דה ÇÌב ÊÚÏםבו Çז ÍÏÝÉ Ýם ÇבזÇÌוÉ זÇבÐם בÏםו ÇבÇÓד order No
create view OrderNo as
select Transaction_ID from InventoryTransactionDetails

