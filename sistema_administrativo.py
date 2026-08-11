import tkinter as tk
from tkinter import ttk, messagebox, filedialog
import sqlite3
import csv
from datetime import datetime

class SistemaAdministrativo:
    def __init__(self, root):
        self.root = root
        self.root.title("Sistema de Control Administrativo")
        self.root.geometry("850x600")

        # Inicializar Base de Datos
        self.init_db()

        # Crear contenedor de Pestañas
        self.notebook = ttk.Notebook(self.root)
        self.notebook.pack(fill="both", expand=True, padx=10, pady=10)

        # Inicializar módulos/pestañas
        self.crear_tab_inventario()
        self.crear_tab_planilla()
        self.crear_tab_caja()
        self.crear_tab_exportar()

    # ==========================================
    # BASE DE DATOS
    # ==========================================
    def init_db(self):
        self.conn = sqlite3.connect("control_administrativo.db")
        self.cursor = self.conn.cursor()

        # Tabla Inventario
        self.cursor.execute("""
            CREATE TABLE IF NOT EXISTS productos (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nombre TEXT NOT NULL,
                precio REAL NOT NULL,
                stock INTEGER NOT NULL
            )
        """)

        # Tabla Planilla / Usuarios
        self.cursor.execute("""
            CREATE TABLE IF NOT EXISTS usuarios (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nombre TEXT NOT NULL,
                puesto TEXT NOT NULL,
                salario REAL NOT NULL
            )
        """)

        # Tabla Caja Registradora
        self.cursor.execute("""
            CREATE TABLE IF NOT EXISTS caja (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                tipo TEXT NOT NULL,
                concepto TEXT NOT NULL,
                monto REAL NOT NULL,
                fecha TEXT NOT NULL
            )
        """)
        self.conn.commit()

    # ==========================================
    # PESTAÑA 1: INVENTARIO
    # ==========================================
    def crear_tab_inventario(self):
        tab = ttk.Frame(self.notebook)
        self.notebook.add(tab, text="Inventario de Productos")

        # Formulario
        frame_form = ttk.LabelFrame(tab, text="Nuevo Producto")
        frame_form.pack(fill="x", padx=10, pady=5)

        ttk.Label(frame_form, text="Nombre:").grid(row=0, column=0, padx=5, pady=5)
        self.ent_inv_nombre = ttk.Entry(frame_form)
        self.ent_inv_nombre.grid(row=0, column=1, padx=5, pady=5)

        ttk.Label(frame_form, text="Precio (Q.):").grid(row=0, column=2, padx=5, pady=5)
        self.ent_inv_precio = ttk.Entry(frame_form)
        self.ent_inv_precio.grid(row=0, column=3, padx=5, pady=5)

        ttk.Label(frame_form, text="Stock:").grid(row=0, column=4, padx=5, pady=5)
        self.ent_inv_stock = ttk.Entry(frame_form)
        self.ent_inv_stock.grid(row=0, column=5, padx=5, pady=5)

        btn_guardar = ttk.Button(frame_form, text="Agregar Producto", command=self.agregar_producto)
        btn_guardar.grid(row=0, column=6, padx=10, pady=5)

        # Tabla
        self.tree_inv = ttk.Treeview(tab, columns=("ID", "Nombre", "Precio", "Stock"), show="headings")
        self.tree_inv.heading("ID", text="ID")
        self.tree_inv.heading("Nombre", text="Nombre")
        self.tree_inv.heading("Precio", text="Precio (Q.)")
        self.tree_inv.heading("Stock", text="Stock")
        self.tree_inv.pack(fill="both", expand=True, padx=10, pady=5)

        self.cargar_inventario()

    def agregar_producto(self):
        nombre = self.ent_inv_nombre.get()
        precio = self.ent_inv_precio.get()
        stock = self.ent_inv_stock.get()

        if nombre and precio and stock:
            try:
                self.cursor.execute("INSERT INTO productos (nombre, precio, stock) VALUES (?, ?, ?)",
                                    (nombre, float(precio), int(stock)))
                self.conn.commit()
                self.cargar_inventario()
                self.ent_inv_nombre.delete(0, tk.END)
                self.ent_inv_precio.delete(0, tk.END)
                self.ent_inv_stock.delete(0, tk.END)
            except ValueError:
                messagebox.showerror("Error", "Precio y Stock deben ser números válidos.")
        else:
            messagebox.showwarning("Atención", "Todos los campos son requeridos.")

    def cargar_inventario(self):
        for item in self.tree_inv.get_children():
            self.tree_inv.delete(item)
        self.cursor.execute("SELECT * FROM productos")
        for row in self.cursor.fetchall():
            self.tree_inv.insert("", "end", values=row)

    # ==========================================
    # PESTAÑA 2: PLANILLA DE USUARIOS
    # ==========================================
    def crear_tab_planilla(self):
        tab = ttk.Frame(self.notebook)
        self.notebook.add(tab, text="Planilla de Empleados")

        frame_form = ttk.LabelFrame(tab, text="Nuevo Empleado")
        frame_form.pack(fill="x", padx=10, pady=5)

        ttk.Label(frame_form, text="Nombre:").grid(row=0, column=0, padx=5, pady=5)
        self.ent_usr_nombre = ttk.Entry(frame_form)
        self.ent_usr_nombre.grid(row=0, column=1, padx=5, pady=5)

        ttk.Label(frame_form, text="Puesto:").grid(row=0, column=2, padx=5, pady=5)
        self.ent_usr_puesto = ttk.Entry(frame_form)
        self.ent_usr_puesto.grid(row=0, column=3, padx=5, pady=5)

        ttk.Label(frame_form, text="Salario (Q.):").grid(row=0, column=4, padx=5, pady=5)
        self.ent_usr_salario = ttk.Entry(frame_form)
        self.ent_usr_salario.grid(row=0, column=5, padx=5, pady=5)

        btn_guardar = ttk.Button(frame_form, text="Agregar Empleado", command=self.agregar_usuario)
        btn_guardar.grid(row=0, column=6, padx=10, pady=5)

        self.tree_usr = ttk.Treeview(tab, columns=("ID", "Nombre", "Puesto", "Salario"), show="headings")
        self.tree_usr.heading("ID", text="ID")
        self.tree_usr.heading("Nombre", text="Nombre Completo")
        self.tree_usr.heading("Puesto", text="Puesto")
        self.tree_usr.heading("Salario", text="Salario Base (Q.)")
        self.tree_usr.pack(fill="both", expand=True, padx=10, pady=5)

        self.cargar_planilla()

    def agregar_usuario(self):
        nombre = self.ent_usr_nombre.get()
        puesto = self.ent_usr_puesto.get()
        salario = self.ent_usr_salario.get()

        if nombre and puesto and salario:
            try:
                self.cursor.execute("INSERT INTO usuarios (nombre, puesto, salario) VALUES (?, ?, ?)",
                                    (nombre, puesto, float(salario)))
                self.conn.commit()
                self.cargar_planilla()
                self.ent_usr_nombre.delete(0, tk.END)
                self.ent_usr_puesto.delete(0, tk.END)
                self.ent_usr_salario.delete(0, tk.END)
            except ValueError:
                messagebox.showerror("Error", "El salario debe ser un número válido.")
        else:
            messagebox.showwarning("Atención", "Todos los campos son requeridos.")

    def cargar_planilla(self):
        for item in self.tree_usr.get_children():
            self.tree_usr.delete(item)
        self.cursor.execute("SELECT * FROM usuarios")
        for row in self.cursor.fetchall():
            self.tree_usr.insert("", "end", values=row)

    # ==========================================
    # PESTAÑA 3: CAJA REGISTRADORA
    # ==========================================
    def crear_tab_caja(self):
        tab = ttk.Frame(self.notebook)
        self.notebook.add(tab, text="Caja Registradora")

        frame_form = ttk.LabelFrame(tab, text="Registrar Movimiento")
        frame_form.pack(fill="x", padx=10, pady=5)

        ttk.Label(frame_form, text="Tipo:").grid(row=0, column=0, padx=5, pady=5)
        self.cmb_caja_tipo = ttk.Combobox(frame_form, values=["Ingreso", "Egreso"], state="readonly")
        self.cmb_caja_tipo.grid(row=0, column=1, padx=5, pady=5)
        self.cmb_caja_tipo.current(0)

        ttk.Label(frame_form, text="Concepto:").grid(row=0, column=2, padx=5, pady=5)
        self.ent_caja_concepto = ttk.Entry(frame_form)
        self.ent_caja_concepto.grid(row=0, column=3, padx=5, pady=5)

        ttk.Label(frame_form, text="Monto (Q.):").grid(row=0, column=4, padx=5, pady=5)
        self.ent_caja_monto = ttk.Entry(frame_form)
        self.ent_caja_monto.grid(row=0, column=5, padx=5, pady=5)

        btn_guardar = ttk.Button(frame_form, text="Registrar", command=self.agregar_movimiento_caja)
        btn_guardar.grid(row=0, column=6, padx=10, pady=5)

        # Label Balance
        self.lbl_balance = ttk.Label(tab, text="Balance Total en Caja: Q. 0.00", font=("Arial", 12, "bold"))
        self.lbl_balance.pack(anchor="e", padx=15, pady=5)

        self.tree_caja = ttk.Treeview(tab, columns=("ID", "Tipo", "Concepto", "Monto", "Fecha"), show="headings")
        self.tree_caja.heading("ID", text="ID")
        self.tree_caja.heading("Tipo", text="Tipo")
        self.tree_caja.heading("Concepto", text="Concepto")
        self.tree_caja.heading("Monto", text="Monto (Q.)")
        self.tree_caja.heading("Fecha", text="Fecha / Hora")
        self.tree_caja.pack(fill="both", expand=True, padx=10, pady=5)

        self.cargar_caja()

    def agregar_movimiento_caja(self):
        tipo = self.cmb_caja_tipo.get()
        concepto = self.ent_caja_concepto.get()
        monto = self.ent_caja_monto.get()
        fecha = datetime.now().strftime("%Y-%m-%d %H:%M:%S")

        if concepto and monto:
            try:
                monto_val = float(monto)
                self.cursor.execute("INSERT INTO caja (tipo, concepto, monto, fecha) VALUES (?, ?, ?, ?)",
                                    (tipo, concepto, monto_val, fecha))
                self.conn.commit()
                self.cargar_caja()
                self.ent_caja_concepto.delete(0, tk.END)
                self.ent_caja_monto.delete(0, tk.END)
            except ValueError:
                messagebox.showerror("Error", "El monto debe ser un número válido.")
        else:
            messagebox.showwarning("Atención", "El concepto y el monto son requeridos.")

    def cargar_caja(self):
        for item in self.tree_caja.get_children():
            self.tree_caja.delete(item)
        self.cursor.execute("SELECT * FROM caja ORDER BY id DESC")
        
        balance = 0.0
        for row in self.cursor.fetchall():
            self.tree_caja.insert("", "end", values=row)
            if row[1] == "Ingreso":
                balance += row[3]
            else:
                balance -= row[3]
        
        self.lbl_balance.config(text=f"Balance Total en Caja: Q. {balance:,.2f}")

    # ==========================================
    # PESTAÑA 4: EXPORTAR A EXCEL
    # ==========================================
    def crear_tab_exportar(self):
        tab = ttk.Frame(self.notebook)
        self.notebook.add(tab, text="Exportar Reportes")

        frame_box = ttk.LabelFrame(tab, text="Generar Reportes compatibles con Excel (.csv)")
        frame_box.pack(fill="both", expand=True, padx=20, pady=20)

        btn_exp_inv = ttk.Button(frame_box, text="Exportar Inventario de Productos", 
                                 command=lambda: self.exportar_a_csv("productos", ["ID", "Nombre", "Precio (Q)", "Stock"]))
        btn_exp_inv.pack(fill="x", padx=40, pady=15)

        btn_exp_usr = ttk.Button(frame_box, text="Exportar Planilla de Empleados", 
                                 command=lambda: self.exportar_a_csv("usuarios", ["ID", "Nombre", "Puesto", "Salario (Q)"]))
        btn_exp_usr.pack(fill="x", padx=40, pady=15)

        btn_exp_caja = ttk.Button(frame_box, text="Exportar Libro de Caja Registradora", 
                                  command=lambda: self.exportar_a_csv("caja", ["ID", "Tipo", "Concepto", "Monto (Q)", "Fecha"]))
        btn_exp_caja.pack(fill="x", padx=40, pady=15)

    def exportar_a_csv(self, tabla, columnas):
        self.cursor.execute(f"SELECT * FROM {tabla}")
        registros = self.cursor.fetchall()

        if not registros:
            messagebox.showwarning("Sin datos", f"No hay registros guardados en la tabla de {tabla}.")
            return

        # Abrir ventana para seleccionar dónde guardar el archivo
        archivo = filedialog.asksaveasfilename(
            defaultextension=".csv",
            filetypes=[("Archivo CSV de Excel", "*.csv"), ("Todos los archivos", "*.*")],
            title=f"Guardar reporte de {tabla}"
        )

        if archivo:
            try:
                with open(archivo, mode="w", newline="", encoding="utf-8-sig") as f:
                    writer = csv.writer(f)
                    writer.writerow(columnas)  # Encabezados
                    writer.writerows(registros)  # Filas de datos
                messagebox.showinfo("Éxito", f"Reporte exportado correctamente en:\n{archivo}")
            except Exception as e:
                messagebox.showerror("Error", f"No se pudo exportar el archivo: {str(e)}")

# Punto de Entrada
if __name__ == "__main__":
    root = tk.Tk()
    app = SistemaAdministrativo(root)
    root.mainloop()