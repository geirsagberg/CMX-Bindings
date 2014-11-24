XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/CmxDependencies.xcodeproj
TARGET=CmxDependencies

all: libUniversal.a

libi386.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
		-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libArmv7.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
		-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libUniversal.a: libi386.a libArmv7.a
		lipo -create -output lib$(TARGET)Universal.a $^

clean:
		-rm -f *.a *.dll
		-rm -rf build