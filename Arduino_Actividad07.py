import tkinter as tk
import serial

port= "COM7"
baudrate = 9600
ser = serial.Serial (port, baudrate)

def encender_led():
    ser.write (b"1")
    print ("LED Encendido")
    
def apagar_led():
    ser.write (b"0")
    print ("LED Apagado")
    
ventana = tk.Tk()
ventana.title("Control de LED")

boton_encender = tk.Button (ventana, text = "Encender LED", command = encender_led)
boton_encender.pack (pady=10)

boton_apagar = tk.Button (ventana, text = "Apagar LED", command = apagar_led)
boton_apagar.pack (pady=10)

ventana.mainloop()

ser.close()
