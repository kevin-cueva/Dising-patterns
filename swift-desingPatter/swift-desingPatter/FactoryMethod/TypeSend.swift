//
//  TypeSend.swift
//  swift-desingPatter
//
//  Created by Neill on 1/02/24.
//

import Foundation

protocol  Envio{
    func costoEnvio(distancia:Double)->Double;
}

class EnvioTerrestre:Envio{
    func costoEnvio(distancia: Double) -> Double {
        return distancia*2.00
    }
    
}

class EnvioAereo:Envio{
    func costoEnvio(distancia: Double) -> Double {
        return distancia*5.00
    }
    
}

class FactoryEnvio{
    static func tipoEnvio(tipo:tipoDeEnvio) -> Envio{
        switch tipo {
        case tipoDeEnvio.terrestre:
            return EnvioTerrestre()
        case tipoDeEnvio.aereo:
            return EnvioAereo()
        }
    }
}

enum tipoDeEnvio{
    case terrestre, aereo
}
