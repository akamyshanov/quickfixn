

def print_usage_and_die
  puts "Usage: ruby update_assembly_version.rb version assembly_filepath"
  puts "Parameters:"
  puts "    version: Where version is a string \"n.n.n\" (e.g. 2.0.143)"
  puts "    assembly_filepath: Path to a VisualStudio AssemblyInfo.cs file"
  exit(1)
end

def is_correct_pattern? ver
  return ver.match(/^[\d]+[.][\d]+[.][\d]+$/)
end

if ARGV[0].nil? or ARGV[1].nil?
  print_usage_and_die
end



vers = ARGV[0]
assemblypath = ARGV[1]

if not is_correct_pattern? vers
  puts "Invalid version string."
  print_usage_and_die
end

if not (File.exists?(assemblypath) and File.writable?(assemblypath))
  puts "Can't open file \"#{assemblypath}\" for writing."
  puts "(Current path: #{Dir.pwd})"
  print_usage_and_die
end

contents = IO.read(assemblypath)
contents.sub!(/AssemblyVersion\([^\)]*\)/, "AssemblyVersion(\"#{vers}.0\")")
contents.sub!(/AssemblyFileVersion\([^\)]*\)/, "AssemblyFileVersion(\"#{vers}.0\")")

File.open(assemblypath,"w") {|f|
  f.write(contents)
}


