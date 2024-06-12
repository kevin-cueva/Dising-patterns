//
//  SingletonBasic.swift
//  swift-desingPatter
//
//  Created by Neill on 5/02/24.
//

import Foundation

class SingletonBasic{
    
    // 1. Crear una propiedad estática para almacenar la única instancia
        static let shared = SingletonBasic()
    // 2. Hacer el constructor privado para evitar instanciación directa
        private init() {
            // Configuración inicial aquí
        }
    // 3. Agregar métodos o propiedades según tus necesidades
        func doSomething() {
            print("Singleton doing something!")
        }
}
