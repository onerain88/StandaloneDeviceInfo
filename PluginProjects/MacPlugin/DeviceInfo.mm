//
//  DeviceInfo.m
//  MacPlugin
//
//  Created by oneRain on 2022/12/10.
//

#import <Foundation/Foundation.h>

extern "C" {
    const char* GetDeviceLocation() {
        return [[[NSLocale currentLocale] countryCode] UTF8String];
    }
    
    const char* GetDeviceLanguage() {
        return [[[[NSUserDefaults standardUserDefaults] objectForKey:@"AppleLanguages"] firstObject] UTF8String];
    }
}
