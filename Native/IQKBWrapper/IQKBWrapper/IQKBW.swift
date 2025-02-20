//
//  Wrapper.swift
//  IQKBWrapper
//
//  Created by Francisco on 2/19/25.
//

internal import IQKeyboardManagerSwift

@objc(IQKBW)
public class IQKBW: NSObject {
    @objc
    public static func enableKB() -> Void {
        DispatchQueue.main.async {
            IQKeyboardManager.shared.isEnabled = true;
        }
    }
}
