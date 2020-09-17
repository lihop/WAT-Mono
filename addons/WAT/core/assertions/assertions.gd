extends Reference

const Utility: Script = preload("utility.gd")

signal OUTPUT
signal asserted

func output(data) -> void:
	emit_signal("asserted", data)

func loop(method: String, data: Array) -> void:
	for set in data:
		callv(method, set)
	
func that(obj: Object, method: String, arguments: Array = [], context: String = "", passed: String = "", failed: String = "") -> void:
	output(Utility.that(obj, method, arguments, context, passed, failed))
		
func fail(context: String = "Unimplemented Test") -> void:
		output(Utility.fail(context))
