//
//  SystemConfiguration.swift
//  swift-desingPatter
//
//  Created by Neill on 5/02/24.
//

import Foundation
class SystemConfiguration{
    static let shared = SystemConfiguration()
    var emphyDictionary = [String: String]()
    private init(){}
    
    func AddConfig(key:String, value: String){
        self.emphyDictionary[key] = value
    }
    
}
