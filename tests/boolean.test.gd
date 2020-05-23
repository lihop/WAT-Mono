extends WAT.Test
#extends "res://addons/WAT/test/test.gd"

func title():
	return "Given a Boolean Assertion"

func test_when_calling_asserts_is_true():
	describe("When calling asserts.is_true(true)")
	
	Assert.IsTrue(true, "Then it passes")
	
func test_when_calling_asserts_is_false():
	describe("When calling asserts.is_false(false)")

	Assert.IsFalse(false, "Then it passes")
