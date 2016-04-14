// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: person.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtobufExample {

  /// <summary>Holder for reflection information generated from person.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PersonReflection {

    #region Descriptor
    /// <summary>File descriptor for person.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxwZXJzb24ucHJvdG8SD1Byb3RvYnVmRXhhbXBsZSLjAQoGUGVyc29uEgwK",
            "BG5hbWUYASABKAkSCgoCaWQYAiABKAUSDQoFZW1haWwYAyABKAkSMwoGcGhv",
            "bmVzGAQgAygLMiMuUHJvdG9idWZFeGFtcGxlLlBlcnNvbi5QaG9uZU51bWJl",
            "chpOCgtQaG9uZU51bWJlchIOCgZudW1iZXIYASABKAkSLwoEdHlwZRgCIAEo",
            "DjIhLlByb3RvYnVmRXhhbXBsZS5QZXJzb24uUGhvbmVUeXBlIisKCVBob25l",
            "VHlwZRIKCgZNT0JJTEUQABIICgRIT01FEAESCAoEV09SSxACIjYKC0FkZHJl",
            "c3NCb29rEicKBnBlcnNvbhgBIAMoCzIXLlByb3RvYnVmRXhhbXBsZS5QZXJz",
            "b25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::ProtobufExample.Person), global::ProtobufExample.Person.Parser, new[]{ "Name", "Id", "Email", "Phones" }, null, new[]{ typeof(global::ProtobufExample.Person.Types.PhoneType) }, new pbr::GeneratedCodeInfo[] { new pbr::GeneratedCodeInfo(typeof(global::ProtobufExample.Person.Types.PhoneNumber), global::ProtobufExample.Person.Types.PhoneNumber.Parser, new[]{ "Number", "Type" }, null, null, null)}),
            new pbr::GeneratedCodeInfo(typeof(global::ProtobufExample.AddressBook), global::ProtobufExample.AddressBook.Parser, new[]{ "Person" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Person : pb::IMessage<Person> {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtobufExample.PersonReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Person(Person other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      email_ = other.email_;
      phones_ = other.phones_.Clone();
    }

    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    public string Email {
      get { return email_; }
      set {
        email_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "phones" field.</summary>
    public const int PhonesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::ProtobufExample.Person.Types.PhoneNumber> _repeated_phones_codec
        = pb::FieldCodec.ForMessage(34, global::ProtobufExample.Person.Types.PhoneNumber.Parser);
    private readonly pbc::RepeatedField<global::ProtobufExample.Person.Types.PhoneNumber> phones_ = new pbc::RepeatedField<global::ProtobufExample.Person.Types.PhoneNumber>();
    public pbc::RepeatedField<global::ProtobufExample.Person.Types.PhoneNumber> Phones {
      get { return phones_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (Email != other.Email) return false;
      if(!phones_.Equals(other.phones_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      hash ^= phones_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      phones_.WriteTo(output, _repeated_phones_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      size += phones_.CalculateSize(_repeated_phones_codec);
      return size;
    }

    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      phones_.Add(other.phones_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            phones_.AddEntriesFrom(input, _repeated_phones_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Person message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum PhoneType {
        MOBILE = 0,
        HOME = 1,
        WORK = 2,
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber> {
        private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
        public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }

        public static pbr::MessageDescriptor Descriptor {
          get { return global::ProtobufExample.Person.Descriptor.NestedTypes[0]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        public PhoneNumber() {
          OnConstruction();
        }

        partial void OnConstruction();

        public PhoneNumber(PhoneNumber other) : this() {
          number_ = other.number_;
          type_ = other.type_;
        }

        public PhoneNumber Clone() {
          return new PhoneNumber(this);
        }

        /// <summary>Field number for the "number" field.</summary>
        public const int NumberFieldNumber = 1;
        private string number_ = "";
        public string Number {
          get { return number_; }
          set {
            number_ = pb::Preconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::ProtobufExample.Person.Types.PhoneType type_ = global::ProtobufExample.Person.Types.PhoneType.MOBILE;
        public global::ProtobufExample.Person.Types.PhoneType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        public override bool Equals(object other) {
          return Equals(other as PhoneNumber);
        }

        public bool Equals(PhoneNumber other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Number != other.Number) return false;
          if (Type != other.Type) return false;
          return true;
        }

        public override int GetHashCode() {
          int hash = 1;
          if (Number.Length != 0) hash ^= Number.GetHashCode();
          if (Type != global::ProtobufExample.Person.Types.PhoneType.MOBILE) hash ^= Type.GetHashCode();
          return hash;
        }

        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Number.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Number);
          }
          if (Type != global::ProtobufExample.Person.Types.PhoneType.MOBILE) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Number.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
          }
          if (Type != global::ProtobufExample.Person.Types.PhoneType.MOBILE) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          return size;
        }

        public void MergeFrom(PhoneNumber other) {
          if (other == null) {
            return;
          }
          if (other.Number.Length != 0) {
            Number = other.Number;
          }
          if (other.Type != global::ProtobufExample.Person.Types.PhoneType.MOBILE) {
            Type = other.Type;
          }
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                Number = input.ReadString();
                break;
              }
              case 16: {
                type_ = (global::ProtobufExample.Person.Types.PhoneType) input.ReadEnum();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AddressBook : pb::IMessage<AddressBook> {
    private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
    public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtobufExample.PersonReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public AddressBook() {
      OnConstruction();
    }

    partial void OnConstruction();

    public AddressBook(AddressBook other) : this() {
      person_ = other.person_.Clone();
    }

    public AddressBook Clone() {
      return new AddressBook(this);
    }

    /// <summary>Field number for the "person" field.</summary>
    public const int PersonFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ProtobufExample.Person> _repeated_person_codec
        = pb::FieldCodec.ForMessage(10, global::ProtobufExample.Person.Parser);
    private readonly pbc::RepeatedField<global::ProtobufExample.Person> person_ = new pbc::RepeatedField<global::ProtobufExample.Person>();
    public pbc::RepeatedField<global::ProtobufExample.Person> Person {
      get { return person_; }
    }

    public override bool Equals(object other) {
      return Equals(other as AddressBook);
    }

    public bool Equals(AddressBook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!person_.Equals(other.person_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= person_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      person_.WriteTo(output, _repeated_person_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += person_.CalculateSize(_repeated_person_codec);
      return size;
    }

    public void MergeFrom(AddressBook other) {
      if (other == null) {
        return;
      }
      person_.Add(other.person_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            person_.AddEntriesFrom(input, _repeated_person_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
