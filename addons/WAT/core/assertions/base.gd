extends Reference

const TYPES = preload("constants/type_library.gd")
var success: bool
var expected: String = "NULL"
var result: String
var notes: String = "No Notes"
var context

func type2str(value):
	return TYPES.get_type_string(typeof(value))
	
func to_dictionary() -> Dictionary:
	return { 
			 "success": success, 
			 "expected": expected, 
			 "actual": result, 
			 "context": context
			}

static func Create(success: bool, expected: String, actual: String, context: String, notes: String = "") -> Reference:
	var result = load("res://addons/WAT/core/assertions/base.gd").new()
	result.success = success
	result.expected = expected
	result.result = actual
	result.context = context
	result.notes = notes
	return result
