extends WAT.TestSuiteOfSuites

class Bool extends WAT.Test:
	
	func title() -> String:
		return "Inner Bool"
		
	func test_true_is_true() -> void:
		
		asserts.is_true(true, "true is true")
		
class Equality extends WAT.Test:
	
	func title() -> String:
		return "Inner Equality"
		
	func test_1_and_1_are_equal() -> void:
		
		asserts.is_equal(1, 1, "1 and 1 are equal") 
