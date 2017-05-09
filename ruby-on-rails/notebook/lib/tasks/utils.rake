namespace :utils do

  desc "Preeenche/popula banco de dados"
  task seed: :environment do
  	puts "Gerando os Contatos (Contacts)..."
		10.times do |i|
			Contact.create!(
				name: Faker::Name.name,
				email: Faker::Internet.email,
				kind: Kind.all.sample,
				rmk: LeroleroGenerator.sentence([1,2,3,4,5].sample)
			)
		end
	puts "Gerando os Contatos (Contacts)... [OK]"

	puts "Gerando os Endereços (Address)..."
		Contact.all.each do |contact|
			Address.create!(
				street: Faker::Address.street_address,
				city: Faker::Address.city,
				state: Faker::Address.state_abbr,
				contact: contact
			)
		end
	puts "Gerando os Endereços (Address)... [OK]"

	puts "Gerando os Telefones (Phones)..."
		Contact.all.each do |contact|
			Random.rand(1..5).times do |i|
				Phone.create!(
					phone: Faker::PhoneNumber.phone_number,
					contact: contact
				)
			end
		end
	puts "Gerando os Telefones (Phones)...[OK]"

  end
end