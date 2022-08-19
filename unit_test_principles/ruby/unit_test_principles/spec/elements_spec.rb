# frozen_string_literal: true

RSpec.describe UnitTestPrinciples::Elements do
  let(:instance) { described_class.new }

  describe "#all" do
    subject { instance.all(params) }

    let(:params) { nil }

    context "with no parameters" do
      let(:response) do
        double(
          body: [
            {
              "id": 1,
              "name": "Gold",
              "symbol": "Au"
            },
            {
              "id": 2,
              "name": "Copper",
              "symbol": "Cu"
            },
            {
              "id": 3,
              "name": "Zinc",
              "symbol": "Zn"
            }
          ]
        )
      end
      let(:expected_endpoint) { URI("http://localhost:3000/elements") }

      it "returns every record" do
        expect(Net::HTTP).to receive(:get_response).with(expected_endpoint).and_return(response)
        expect(subject).to eq(response.body)
      end
    end

    context "with valid parameters" do
      let(:params) { { symbol: "Au" } }
      let(:response) do
        double(
          body: [
            {
              "id": 1,
              "name": "Gold",
              "symbol": "Au"
            }
          ]
        )
      end
      let(:expected_endpoint) { URI("http://localhost:3000/elements?symbol=Au") }

      it "returns only matching records" do
        expect(Net::HTTP).to receive(:get_response).with(expected_endpoint).and_return(response)
        expect(subject).to eq(response.body)
      end
    end

    context "with empty response" do
      let(:params) { nil }
      let(:response) { double(body: []) }
      let(:expected_endpoint) { URI("http://localhost:3000/elements") }

      it "returns an empty array" do
        expect(Net::HTTP).to receive(:get_response).with(expected_endpoint).and_return(response)
        expect(subject).to be_empty
      end
    end
  end

  describe "#find" do
    subject { instance.find(id) }

    let(:id) { nil }

    context "nil id given" do
      let(:id) { nil }

      it "raises an error" do
        expect { subject }.to raise_error("id param is required")
      end
    end

    context "valid id given" do
      let(:id) { 1 }
      let(:response) do
        double(
          body: {
            "id": 1,
            "name": "Gold",
            "symbol": "Au"
          }
        )
      end
      let(:expected_endpoint) { URI("http://localhost:3000/elements/1") }

      it "returns the valid element" do
        expect(Net::HTTP).to receive(:get_response).with(expected_endpoint).and_return(response)
        expect(subject).to eq(response.body)
      end
    end

    context "invalid id given" do
      let(:id) { -1 }
      let(:response) { double(body: {}) }

      let(:expected_endpoint) { URI("http://localhost:3000/elements/-1") }

      it "returns an empty object" do
        expect(Net::HTTP).to receive(:get_response).with(expected_endpoint).and_return(response)
        expect(subject).to eq(response.body)
      end
    end
  end
end
