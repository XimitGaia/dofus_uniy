using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x20005C9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntitySpawnInformation : IMessage<EntitySpawnInformation>, IMessage, IEquatable<EntitySpawnInformation>, IDeepCloneable<EntitySpawnInformation>, IBufferMessage
{
	[Token(Token = "0x20005CA")]
	public enum SpawnInformationOneofCase
	{
		[Token(Token = "0x4001436")]
		None,
		[Token(Token = "0x4001437")]
		Monster,
		[Token(Token = "0x4001438")]
		Character,
		[Token(Token = "0x4001439")]
		Companion
	}

	[Token(Token = "0x20005CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20005CC")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Monster : IMessage<Monster>, IMessage, IEquatable<Monster>, IDeepCloneable<Monster>, IBufferMessage
		{
			[Token(Token = "0x20005CD")]
			public enum InvocationInformationOneofCase
			{
				[Token(Token = "0x4001443")]
				None = 0,
				[Token(Token = "0x4001444")]
				Grade = 2,
				[Token(Token = "0x4001445")]
				Level = 3
			}

			[Token(Token = "0x400143A")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Monster> _parser;

			[Token(Token = "0x400143B")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400143C")]
			public const int MonsterGidFieldNumber = 1;

			[Token(Token = "0x400143D")]
			[FieldOffset(Offset = "0x18")]
			private int monsterGid_;

			[Token(Token = "0x400143E")]
			public const int GradeFieldNumber = 2;

			[Token(Token = "0x400143F")]
			public const int LevelFieldNumber = 3;

			[Token(Token = "0x4001440")]
			[FieldOffset(Offset = "0x20")]
			private object invocationInformation_;

			[Token(Token = "0x4001441")]
			[FieldOffset(Offset = "0x28")]
			private InvocationInformationOneofCase invocationInformationCase_;

			[Token(Token = "0x17000D42")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Monster> Parser
			{
				[Token(Token = "0x6003DE0")]
				[Address(RVA = "0xA517A0", Offset = "0xA50BA0", VA = "0x180A517A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D43")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003DE1")]
				[Address(RVA = "0xA51620", Offset = "0xA50A20", VA = "0x180A51620")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D44")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003DE2")]
				[Address(RVA = "0xA51A20", Offset = "0xA50E20", VA = "0x180A51A20", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D45")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int MonsterGid
			{
				[Token(Token = "0x6003DE6")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003DE7")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000D46")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Grade
			{
				[Token(Token = "0x6003DE8")]
				[Address(RVA = "0xA516A0", Offset = "0xA50AA0", VA = "0x180A516A0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003DE9")]
				[Address(RVA = "0xA51AD0", Offset = "0xA50ED0", VA = "0x180A51AD0")]
				set
				{
				}
			}

			[Token(Token = "0x17000D47")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasGrade
			{
				[Token(Token = "0x6003DEA")]
				[Address(RVA = "0xA51710", Offset = "0xA50B10", VA = "0x180A51710")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000D48")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Level
			{
				[Token(Token = "0x6003DEC")]
				[Address(RVA = "0xA51730", Offset = "0xA50B30", VA = "0x180A51730")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003DED")]
				[Address(RVA = "0xA51B40", Offset = "0xA50F40", VA = "0x180A51B40")]
				set
				{
				}
			}

			[Token(Token = "0x17000D49")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool HasLevel
			{
				[Token(Token = "0x6003DEE")]
				[Address(RVA = "0xA51720", Offset = "0xA50B20", VA = "0x180A51720")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000D4A")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public InvocationInformationOneofCase InvocationInformationCase
			{
				[Token(Token = "0x6003DF0")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(InvocationInformationOneofCase);
				}
			}

			[Token(Token = "0x6003DE3")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Monster()
			{
			}

			[Token(Token = "0x6003DE4")]
			[Address(RVA = "0xA51540", Offset = "0xA50940", VA = "0x180A51540")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Monster(Monster other)
			{
			}

			[Token(Token = "0x6003DE5")]
			[Address(RVA = "0xA50F60", Offset = "0xA50360", VA = "0x180A50F60", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Monster Clone()
			{
				return null;
			}

			[Token(Token = "0x6003DEB")]
			[Address(RVA = "0xA50F20", Offset = "0xA50320", VA = "0x180A50F20")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearGrade()
			{
			}

			[Token(Token = "0x6003DEF")]
			[Address(RVA = "0xA50F40", Offset = "0xA50340", VA = "0x180A50F40")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void ClearLevel()
			{
			}

			[Token(Token = "0x6003DF1")]
			[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearInvocationInformation()
			{
			}

			[Token(Token = "0x6003DF2")]
			[Address(RVA = "0xA51120", Offset = "0xA50520", VA = "0x180A51120", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003DF3")]
			[Address(RVA = "0xA51070", Offset = "0xA50470", VA = "0x180A51070", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Monster other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003DF4")]
			[Address(RVA = "0xA51200", Offset = "0xA50600", VA = "0x180A51200", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003DF5")]
			[Address(RVA = "0xA513E0", Offset = "0xA507E0", VA = "0x180A513E0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003DF6")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003DF7")]
			[Address(RVA = "0xA518D0", Offset = "0xA50CD0", VA = "0x180A518D0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003DF8")]
			[Address(RVA = "0xA50D90", Offset = "0xA50190", VA = "0x180A50D90", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003DF9")]
			[Address(RVA = "0xA51350", Offset = "0xA50750", VA = "0x180A51350", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Monster other)
			{
			}

			[Token(Token = "0x6003DFA")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003DFB")]
			[Address(RVA = "0xA517F0", Offset = "0xA50BF0", VA = "0x180A517F0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005CF")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Character : IMessage<Character>, IMessage, IEquatable<Character>, IDeepCloneable<Character>, IBufferMessage
		{
			[Token(Token = "0x4001447")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Character> _parser;

			[Token(Token = "0x4001448")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001449")]
			public const int NameFieldNumber = 1;

			[Token(Token = "0x400144A")]
			[FieldOffset(Offset = "0x18")]
			private string name_;

			[Token(Token = "0x400144B")]
			public const int LevelFieldNumber = 2;

			[Token(Token = "0x400144C")]
			[FieldOffset(Offset = "0x20")]
			private int level_;

			[Token(Token = "0x17000D4B")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<Character> Parser
			{
				[Token(Token = "0x6003E00")]
				[Address(RVA = "0xA3B7D0", Offset = "0xA3ABD0", VA = "0x180A3B7D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D4C")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003E01")]
				[Address(RVA = "0xA3B750", Offset = "0xA3AB50", VA = "0x180A3B750")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D4D")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003E02")]
				[Address(RVA = "0xA3B8F0", Offset = "0xA3ACF0", VA = "0x180A3B8F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D4E")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public string Name
			{
				[Token(Token = "0x6003E06")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003E07")]
				[Address(RVA = "0xA3B9A0", Offset = "0xA3ADA0", VA = "0x180A3B9A0")]
				set
				{
				}
			}

			[Token(Token = "0x17000D4F")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Level
			{
				[Token(Token = "0x6003E08")]
				[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003E09")]
				[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
				set
				{
				}
			}

			[Token(Token = "0x6003E03")]
			[Address(RVA = "0xA3B650", Offset = "0xA3AA50", VA = "0x180A3B650")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Character()
			{
			}

			[Token(Token = "0x6003E04")]
			[Address(RVA = "0xA3B6A0", Offset = "0xA3AAA0", VA = "0x180A3B6A0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Character(Character other)
			{
			}

			[Token(Token = "0x6003E05")]
			[Address(RVA = "0xA3B300", Offset = "0xA3A700", VA = "0x180A3B300", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Character Clone()
			{
				return null;
			}

			[Token(Token = "0x6003E0A")]
			[Address(RVA = "0xA3B3D0", Offset = "0xA3A7D0", VA = "0x180A3B3D0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003E0B")]
			[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(Character other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003E0C")]
			[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003E0D")]
			[Address(RVA = "0xA3B4F0", Offset = "0xA3A8F0", VA = "0x180A3B4F0", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003E0E")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003E0F")]
			[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003E10")]
			[Address(RVA = "0xA3B240", Offset = "0xA3A640", VA = "0x180A3B240", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003E11")]
			[Address(RVA = "0xA3B480", Offset = "0xA3A880", VA = "0x180A3B480", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(Character other)
			{
			}

			[Token(Token = "0x6003E12")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003E13")]
			[Address(RVA = "0xA3B820", Offset = "0xA3AC20", VA = "0x180A3B820", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x20005D1")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class Companion : IMessage<Companion>, IMessage, IEquatable<Companion>, IDeepCloneable<Companion>, IBufferMessage
		{
			[Token(Token = "0x400144E")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<Companion> _parser;

			[Token(Token = "0x400144F")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4001450")]
			public const int ModelIdFieldNumber = 1;

			[Token(Token = "0x4001451")]
			[FieldOffset(Offset = "0x18")]
			private int modelId_;

			[Token(Token = "0x4001452")]
			public const int LevelFieldNumber = 2;

			[Token(Token = "0x4001453")]
			[FieldOffset(Offset = "0x1C")]
			private int level_;

			[Token(Token = "0x4001454")]
			public const int SummonerIdFieldNumber = 3;

			[Token(Token = "0x4001455")]
			[FieldOffset(Offset = "0x20")]
			private long summonerId_;

			[Token(Token = "0x4001456")]
			public const int OwnerIdFieldNumber = 4;

			[Token(Token = "0x4001457")]
			[FieldOffset(Offset = "0x28")]
			private long ownerId_;

			[Token(Token = "0x17000D50")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<Companion> Parser
			{
				[Token(Token = "0x6003E18")]
				[Address(RVA = "0xA3C050", Offset = "0xA3B450", VA = "0x180A3C050")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D51")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6003E19")]
				[Address(RVA = "0xA3BFD0", Offset = "0xA3B3D0", VA = "0x180A3BFD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D52")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6003E1A")]
				[Address(RVA = "0xA3C260", Offset = "0xA3B660", VA = "0x180A3C260", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000D53")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int ModelId
			{
				[Token(Token = "0x6003E1E")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003E1F")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000D54")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int Level
			{
				[Token(Token = "0x6003E20")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003E21")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x17000D55")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public long SummonerId
			{
				[Token(Token = "0x6003E22")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003E23")]
				[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000D56")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long OwnerId
			{
				[Token(Token = "0x6003E24")]
				[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6003E25")]
				[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
				set
				{
				}
			}

			[Token(Token = "0x6003E1B")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Companion()
			{
			}

			[Token(Token = "0x6003E1C")]
			[Address(RVA = "0xA3BF60", Offset = "0xA3B360", VA = "0x180A3BF60")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Companion(Companion other)
			{
			}

			[Token(Token = "0x6003E1D")]
			[Address(RVA = "0xA3BB20", Offset = "0xA3AF20", VA = "0x180A3BB20", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Companion Clone()
			{
				return null;
			}

			[Token(Token = "0x6003E26")]
			[Address(RVA = "0xA3BBC0", Offset = "0xA3AFC0", VA = "0x180A3BBC0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003E27")]
			[Address(RVA = "0xA3BC70", Offset = "0xA3B070", VA = "0x180A3BC70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(Companion other)
			{
				return default(bool);
			}

			[Token(Token = "0x6003E28")]
			[Address(RVA = "0xA3BCC0", Offset = "0xA3B0C0", VA = "0x180A3BCC0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6003E29")]
			[Address(RVA = "0xA3BE00", Offset = "0xA3B200", VA = "0x180A3BE00", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6003E2A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6003E2B")]
			[Address(RVA = "0xA3C1A0", Offset = "0xA3B5A0", VA = "0x180A3C1A0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6003E2C")]
			[Address(RVA = "0xA3BA10", Offset = "0xA3AE10", VA = "0x180A3BA10", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6003E2D")]
			[Address(RVA = "0xA3BD80", Offset = "0xA3B180", VA = "0x180A3BD80", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(Companion other)
			{
			}

			[Token(Token = "0x6003E2E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6003E2F")]
			[Address(RVA = "0xA3C0A0", Offset = "0xA3B4A0", VA = "0x180A3C0A0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x400142E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EntitySpawnInformation> _parser;

	[Token(Token = "0x400142F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001430")]
	public const int MonsterFieldNumber = 1;

	[Token(Token = "0x4001431")]
	public const int CharacterFieldNumber = 2;

	[Token(Token = "0x4001432")]
	public const int CompanionFieldNumber = 3;

	[Token(Token = "0x4001433")]
	[FieldOffset(Offset = "0x18")]
	private object spawnInformation_;

	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x20")]
	private SpawnInformationOneofCase spawnInformationCase_;

	[Token(Token = "0x17000D3B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EntitySpawnInformation> Parser
	{
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0xA2A1D0", Offset = "0xA295D0", VA = "0x180A2A1D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D3C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0xA2A0C0", Offset = "0xA294C0", VA = "0x180A2A0C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D3D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0xA2A5D0", Offset = "0xA299D0", VA = "0x180A2A5D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D3E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Monster Monster
	{
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0xA2A170", Offset = "0xA29570", VA = "0x180A2A170")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Character Character
	{
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0xA2A000", Offset = "0xA29400", VA = "0x180A2A000")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000D40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Companion Companion
	{
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0xA2A060", Offset = "0xA29460", VA = "0x180A2A060")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x919620", Offset = "0x918A20", VA = "0x180919620")]
		set
		{
		}
	}

	[Token(Token = "0x17000D41")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpawnInformationOneofCase SpawnInformationCase
	{
		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SpawnInformationOneofCase);
		}
	}

	[Token(Token = "0x6003DCA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntitySpawnInformation()
	{
	}

	[Token(Token = "0x6003DCB")]
	[Address(RVA = "0xA29E10", Offset = "0xA29210", VA = "0x180A29E10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntitySpawnInformation(EntitySpawnInformation other)
	{
	}

	[Token(Token = "0x6003DCC")]
	[Address(RVA = "0xA296F0", Offset = "0xA28AF0", VA = "0x180A296F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntitySpawnInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x6003DD4")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearSpawnInformation()
	{
	}

	[Token(Token = "0x6003DD5")]
	[Address(RVA = "0xA298B0", Offset = "0xA28CB0", VA = "0x180A298B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DD6")]
	[Address(RVA = "0xA29750", Offset = "0xA28B50", VA = "0x180A29750", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EntitySpawnInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DD7")]
	[Address(RVA = "0xA29910", Offset = "0xA28D10", VA = "0x180A29910", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003DD8")]
	[Address(RVA = "0xA29CB0", Offset = "0xA290B0", VA = "0x180A29CB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003DD9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003DDA")]
	[Address(RVA = "0xA2A450", Offset = "0xA29850", VA = "0x180A2A450", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003DDB")]
	[Address(RVA = "0xA29540", Offset = "0xA28940", VA = "0x180A29540", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003DDC")]
	[Address(RVA = "0xA29AB0", Offset = "0xA28EB0", VA = "0x180A29AB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntitySpawnInformation other)
	{
	}

	[Token(Token = "0x6003DDD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003DDE")]
	[Address(RVA = "0xA2A220", Offset = "0xA29620", VA = "0x180A2A220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
