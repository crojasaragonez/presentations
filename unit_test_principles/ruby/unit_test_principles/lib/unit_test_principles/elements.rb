# frozen_string_literal: true

require "uri"
require "net/http"

module UnitTestPrinciples
  class Elements
    BASE_URL = "http://localhost:3000"

    def all(params = nil)
      uri = URI("#{BASE_URL}/elements")
      uri.query = URI.encode_www_form(params) unless params.nil?
      Net::HTTP.get_response(uri).body
    end

    def find(id)
      raise "id param is required" if id.nil?

      uri = URI("#{BASE_URL}/elements/#{id}")
      Net::HTTP.get_response(uri).body
    end
  end
end
