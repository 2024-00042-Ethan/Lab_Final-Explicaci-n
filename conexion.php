<?php
$host = 'localhost';
$db   = 'gestion_productos';
$user = 'root'; // Ajusta según tu configuración
$pass = '';     // Ajusta según tu configuración

try {
    $pdo = new PDO("mysql:host=$host;dbname=$db;charset=utf8", $user, $pass);
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    die("Error en la conexión a la base de datos: " . $e->getMessage());
}
?>