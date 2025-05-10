-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: boatreservationdb
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `revenuesummaryview`
--

DROP TABLE IF EXISTS `revenuesummaryview`;
/*!50001 DROP VIEW IF EXISTS `revenuesummaryview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `revenuesummaryview` AS SELECT 
 1 AS `user_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `total_spent`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `userreservationsview`
--

DROP TABLE IF EXISTS `userreservationsview`;
/*!50001 DROP VIEW IF EXISTS `userreservationsview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `userreservationsview` AS SELECT 
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `boat_name`,
 1 AS `departure_time`,
 1 AS `arrival_time`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `pendingreservationsview`
--

DROP TABLE IF EXISTS `pendingreservationsview`;
/*!50001 DROP VIEW IF EXISTS `pendingreservationsview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `pendingreservationsview` AS SELECT 
 1 AS `reservation_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `boat_name`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `scheduleoverviewview`
--

DROP TABLE IF EXISTS `scheduleoverviewview`;
/*!50001 DROP VIEW IF EXISTS `scheduleoverviewview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `scheduleoverviewview` AS SELECT 
 1 AS `boat_name`,
 1 AS `port_name`,
 1 AS `departure_time`,
 1 AS `arrival_time`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `activeboatsview`
--

DROP TABLE IF EXISTS `activeboatsview`;
/*!50001 DROP VIEW IF EXISTS `activeboatsview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `activeboatsview` AS SELECT 
 1 AS `boat_id`,
 1 AS `name`,
 1 AS `type`,
 1 AS `capacity`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `revenuesummaryview`
--

/*!50001 DROP VIEW IF EXISTS `revenuesummaryview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `revenuesummaryview` AS select `u`.`user_id` AS `user_id`,`u`.`first_name` AS `first_name`,`u`.`last_name` AS `last_name`,sum(`p`.`amount`) AS `total_spent` from (`payments` `p` join `users` `u` on((`p`.`user_id` = `u`.`user_id`))) group by `u`.`user_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `userreservationsview`
--

/*!50001 DROP VIEW IF EXISTS `userreservationsview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `userreservationsview` AS select `u`.`first_name` AS `first_name`,`u`.`last_name` AS `last_name`,`b`.`name` AS `boat_name`,`s`.`departure_time` AS `departure_time`,`s`.`arrival_time` AS `arrival_time` from (((`reservations` `r` join `users` `u` on((`r`.`user_id` = `u`.`user_id`))) join `boats` `b` on((`r`.`boat_id` = `b`.`boat_id`))) join `schedules` `s` on((`r`.`schedule_id` = `s`.`schedule_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pendingreservationsview`
--

/*!50001 DROP VIEW IF EXISTS `pendingreservationsview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pendingreservationsview` AS select `r`.`reservation_id` AS `reservation_id`,`u`.`first_name` AS `first_name`,`u`.`last_name` AS `last_name`,`b`.`name` AS `boat_name`,`r`.`status` AS `status` from ((`reservations` `r` join `users` `u` on((`r`.`user_id` = `u`.`user_id`))) join `boats` `b` on((`r`.`boat_id` = `b`.`boat_id`))) where (`r`.`status` = 'Pending') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `scheduleoverviewview`
--

/*!50001 DROP VIEW IF EXISTS `scheduleoverviewview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `scheduleoverviewview` AS select `b`.`name` AS `boat_name`,`p`.`name` AS `port_name`,`s`.`departure_time` AS `departure_time`,`s`.`arrival_time` AS `arrival_time` from ((`schedules` `s` join `boats` `b` on((`s`.`boat_id` = `b`.`boat_id`))) join `ports` `p` on((`s`.`port_id` = `p`.`port_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `activeboatsview`
--

/*!50001 DROP VIEW IF EXISTS `activeboatsview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `activeboatsview` AS select `boats`.`boat_id` AS `boat_id`,`boats`.`name` AS `name`,`boats`.`type` AS `type`,`boats`.`capacity` AS `capacity`,`boats`.`status` AS `status` from `boats` where (`boats`.`status` = 'Available') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Dumping events for database 'boatreservationdb'
--

--
-- Dumping routines for database 'boatreservationdb'
--
/*!50003 DROP PROCEDURE IF EXISTS `AddReservation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddReservation`(IN userId INT, IN boatId INT, IN scheduleId INT)
BEGIN
    INSERT INTO Reservations (user_id, boat_id, schedule_id, status) VALUES (userId, boatId, scheduleId, 'Pending');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CalculateTotalRevenue` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CalculateTotalRevenue`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE payment_amount DECIMAL(10,2);
    DECLARE total_revenue DECIMAL(10,2) DEFAULT 0.00;

    -- Declare a cursor to fetch all completed payments
    DECLARE revenue_cursor CURSOR FOR 
    SELECT amount
    FROM Payments
    WHERE status = 'Completed';

    -- Handler for when the cursor reaches the end of data
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    OPEN revenue_cursor;

    read_loop: LOOP
        FETCH revenue_cursor INTO payment_amount;
        IF done THEN
            LEAVE read_loop;
        END IF;
        
        -- Accumulate the total revenue
        SET total_revenue = total_revenue + payment_amount;
    END LOOP;

    CLOSE revenue_cursor;

    -- Return the total revenue
    SELECT total_revenue AS 'Total Revenue';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ListPendingReservations` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListPendingReservations`()
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE resId INT;
    DECLARE resCursor CURSOR FOR SELECT reservation_id FROM Reservations WHERE status = 'Pending';
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;
    OPEN resCursor;
    read_loop: LOOP
        FETCH resCursor INTO resId;
        IF done THEN
            LEAVE read_loop;
        END IF;
        SELECT resId;
    END LOOP;
    CLOSE resCursor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdatePaymentStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePaymentStatus`(IN paymentId INT, IN newStatus VARCHAR(20))
BEGIN
    UPDATE Payments SET status = newStatus WHERE payment_id = paymentId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-21  1:26:30
