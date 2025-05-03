class Phone:
    line_type = 'проводной'


rotary_phone = Phone()
keypad_phone = Phone()

# Печать содержимого атрибута line_type через объект rotary_phone.
print(rotary_phone.line_type)
# Печать содержимого атрибута line_type через объект keypad_phone.
print(keypad_phone.line_type)

# Выведется:
# проводной
# проводной